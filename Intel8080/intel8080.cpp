#include "pch.h"
#include "intel8080.h"
#include "timeapi.h"

// Code by nicsure (C)2022
// https://www.youtube.com/nicsure

// It's been long time (8 years) since I did any C++ so I was very rusty.
// All of this is static and only able to emulate one CPU, it could be
// objectified to run multiple instances easily enough, but this was all
// I needed for the time being.

// The CPU emulator passes both the CPUTEST.COM and 8080EXM.COM tests so
// it's pretty close to being accurate, that doesn't rule out potential errors
// though so be aware of that.

// The emulator has a flat fixed 64k of RAM. You can however map all or
// part of the RAM to an external function. This allows RAM monitoring,
// paging and all that good stuff. Check the .h file for info on doing this.

#define PEEK 0x00
#define POKE 0x01

static PortInCallback portInCallback;
static PortOutCallback portOutCallback;
static StatusCallback statusCallback;

static const UINT8 OP_TCOUNT[256] =
{
	4,10,7,5,5,5,7,4,4,10,7,5,5,5,7,4,
	4,10,7,5,5,5,7,4,4,10,7,5,5,5,7,4,
	4,10,16,5,5,5,7,4,4,10,16,5,5,5,7,4,
	4,10,13,5,10,10,10,4,4,10,13,5,5,5,7,4,
	5,5,5,5,5,5,7,5,5,5,5,5,5,5,7,5,
	5,5,5,5,5,5,7,5,5,5,5,5,5,5,7,5,
	5,5,5,5,5,5,7,5,5,5,5,5,5,5,7,5,
	7,7,7,7,7,7,7,7,5,5,5,5,5,5,7,5,
	4,4,4,4,4,4,7,4,4,4,4,4,4,4,7,4,
	4,4,4,4,4,4,7,4,4,4,4,4,4,4,7,4,
	4,4,4,4,4,4,7,4,4,4,4,4,4,4,7,4,
	4,4,4,4,4,4,7,4,4,4,4,4,4,4,7,4,
	5,10,10,10,11,11,7,11,5,10,10,10,11,17,7,11,
	5,10,10,10,11,11,7,11,5,10,10,10,11,17,7,11,
	5,10,10,18,11,11,7,11,5,5,10,4,11,17,7,11,
	5,10,10,4,11,11,7,11,5,5,10,4,11,17,7,11
};

static const bool PARITY[256] =
{
	1,0,0,1,0,1,1,0,0,1,1,0,1,0,0,1,
	0,1,1,0,1,0,0,1,1,0,0,1,0,1,1,0,
	0,1,1,0,1,0,0,1,1,0,0,1,0,1,1,0,
	1,0,0,1,0,1,1,0,0,1,1,0,1,0,0,1,
	0,1,1,0,1,0,0,1,1,0,0,1,0,1,1,0,
	1,0,0,1,0,1,1,0,0,1,1,0,1,0,0,1,
	1,0,0,1,0,1,1,0,0,1,1,0,1,0,0,1,
	0,1,1,0,1,0,0,1,1,0,0,1,0,1,1,0,
	0,1,1,0,1,0,0,1,1,0,0,1,0,1,1,0,
	1,0,0,1,0,1,1,0,0,1,1,0,1,0,0,1,
	1,0,0,1,0,1,1,0,0,1,1,0,1,0,0,1,
	0,1,1,0,1,0,0,1,1,0,0,1,0,1,1,0,
	1,0,0,1,0,1,1,0,0,1,1,0,1,0,0,1,
	0,1,1,0,1,0,0,1,1,0,0,1,0,1,1,0,
	0,1,1,0,1,0,0,1,1,0,0,1,0,1,1,0,
	1,0,0,1,0,1,1,0,0,1,1,0,1,0,0,1
};

static UINT8 STATE[65792];
static UINT8 STATUS[140];
static UINT8* RAM = (UINT8*)&STATE[0x100];
static RamCallback RAMMAP[65536];
static RamCallback READONLY = (RamCallback)-1;
static RamCallback READWRITE = (RamCallback)0; // a memory pointer to a function is never going to be 0 or 0xFFFFFFFF...

static UINT16* BC = (UINT16*)&STATE[0];
static UINT16* DE = (UINT16*)&STATE[2];
static UINT16* HL = (UINT16*)&STATE[4];
static UINT16* AF = (UINT16*)&STATE[6];
static UINT16* SP = (UINT16*)&STATE[8];
static UINT16* PC = (UINT16*)&STATE[10];

static UINT8* A = (UINT8*)&STATE[7];
static UINT8* F = (UINT8*)&STATE[6];
static UINT8* B = (UINT8*)&STATE[1];
static UINT8* C = (UINT8*)&STATE[0];
static UINT8* D = (UINT8*)&STATE[3];
static UINT8* E = (UINT8*)&STATE[2];
static UINT8* H = (UINT8*)&STATE[5];
static UINT8* L = (UINT8*)&STATE[4];
static UINT8* IV = (UINT8*)&STATE[12];
static bool* EI = (bool*)&STATE[16];
static bool* HLT = (bool*)&STATE[20];

static UINT32* sA = (UINT32*)&STATUS[0];
static UINT32* sD = (UINT32*)&STATUS[64];
static UINT32* sWAIT = (UINT32*)&STATUS[96];
static UINT32* sEI = (UINT32*)&STATUS[100];
static UINT32* sRM = (UINT32*)&STATUS[104];
static UINT32* sIN = (UINT32*)&STATUS[108];
static UINT32* sM1 = (UINT32*)&STATUS[112];
static UINT32* sOUT = (UINT32*)&STATUS[116];
static UINT32* sHLT = (UINT32*)&STATUS[120];
static UINT32* sSTK = (UINT32*)&STATUS[124];
static UINT32* sWO = (UINT32*)&STATUS[128];
static UINT32* sINT = (UINT32*)&STATUS[132];
static UINT32* sCNT = (UINT32*)&STATUS[136];

static bool bRM;
static bool bIN;
static bool bM1;
static bool bOUT;
static bool bSTK;
static bool bWO;
static bool bINT;

static UINT64 tsCount;
static DWORD timerCount;
static bool requestEI;
static HANDLE pauseMutex;
static DWORD startTime;
static UINT64 speed;
static bool running;
static bool step;
static bool stepping;
static bool doStatus;
static bool updatedPC;
static bool incPC;

static int currentOP;

DLL void SetExternal(UINT16 start, UINT16 end, RamCallback callBack)
{
	for (int i = start; i <= end; i++)
		RAMMAP[i] = callBack;	
}

DLL void SetROM(UINT16 start, UINT16 end)
{
	SetExternal(start, end, READONLY);
}

DLL void SetRAM(UINT16 start, UINT16 end)
{
	SetExternal(start, end, READWRITE);
}

DLL void Init(PortInCallback portIn, PortOutCallback portOut, StatusCallback status, UINT16 spd)
{
	portInCallback = portIn;
	portOutCallback = portOut;
	statusCallback = status;
	speed = spd;
	pauseMutex = CreateMutex(NULL, TRUE, NULL);
	doStatus = status && true;
	requestEI = 0;
	step = 0;
	stepping = 0;
	running = 0;
	updatedPC = 0;
	running = 0;
	incPC = 0;
	SetRAM(0, 65535);
}

DLL void Start() { LOOP(); }

DLL void ShutDown()
{
	ReleaseMutex(pauseMutex);
}

DLL void Interrupt(UINT8 vector)
{
	if (*EI)
	{
		*IV = vector;
	}
}

DLL void Reset() { RESET(FALSE); }

DLL void HardReset() { RESET(TRUE); }

DLL void Speed(UINT16 spd)
{
	bool oldRunning = running;
	Stop();
	speed = spd;
	if (oldRunning)
		Run();
}

DLL void Run()
{
	if (stepping)
	{
		step = FALSE;
		startTime = timeGetTime();
		tsCount = 0;
		running = TRUE;
	}
}

DLL void Stop()
{
	int cnt = 0;
	do {
		step = 0;
		running = 0; // stop running		
	} while (!stepping && cnt++ < 100000000);  // wait to enter stepping state
	// using a spin loop here is something I'm not happy about at all
	// but if I try using Sleep(), it somehow causes issues with
	// .NET for some reason and ends up not returning from Sleep() occasionally
	// locking up the STA thread. Not sure why this happens or have the time to
	// investigate, so the somewhat ickky solution was to use a spin loop.
}

DLL void Step()
{
	if(stepping)
		step = TRUE;
}

DLL UINT8 Examine(UINT16 addr)
{
	UINT8 v = RAM8(addr); // get the byte at this address
	if (stepping) // only if we're in stepping mode
	{
		*PC = addr; // set the PC to this address
		updatedPC = 1;
	}	
	return v; // return the byte at that address
}

DLL void Deposit(UINT16 addr, UINT8 data)
{
	if (stepping) // only if we're in stepping mode
	{
		RAM8(addr, data); // poke the byte into ram
		*PC = addr; // set the PC to this address
		updatedPC = 1;
	}
}

DLL void ToRam(UINT8* data, UINT16 addr, UINT16 len)
{
	for (int i = 0; i < len; i++)
	{
		RAM[addr++] = data[i];
	}
}

DLL UINT8* State()
{
	return (UINT8*)STATE;
}

DLL void SetDoStatus(bool b)
{
	doStatus = b;
}

DLL bool IsRunning()
{
	return running;
}

// read cpu flag
bool CF() { return *F & 1; }
bool PF() { return *F & 4; }
bool HF() { return *F & 16; }
bool ZF() { return *F & 64; }
bool SF() { return *F & 128; }

// read inverted cpu flag
bool CFN() { return !CF(); }
bool PFN() { return !PF(); }
bool HFN() { return !HF(); }
bool ZFN() { return !ZF(); }
bool SFN() { return !SF(); }

// invert a flag
void CFI() { *F ^= 1; }
void PFI() { *F ^= 4; }
void HFI() { *F ^= 16; }
void ZFI() { *F ^= 64; }
void SFI() { *F ^= 128; }

// set a flag to 0
void CF0() { *F &= 254; }
void PF0() { *F &= 251; }
void HF0() { *F &= 239; }
void ZF0() { *F &= 191; }
void SF0() { *F &= 127; }

// set a flag to 1
void CF1() { *F |= 1; }
void PF1() { *F |= 4; }
void HF1() { *F |= 16; }
void ZF1() { *F |= 64; }
void SF1() { *F |= 128; }

// call tables for setting flags based on a bool value (0 [first element] or 1 [second element])
static VoidCall CFV[] = { CF0, CF1 };
static VoidCall PFV[] = { PF0, PF1 };
static VoidCall HFV[] = { HF0, HF1 };
static VoidCall ZFV[] = { ZF0, ZF1 };
static VoidCall SFV[] = { SF0, SF1 };

// set a flag depending on the bool parameter
void CF(bool v) { CFV[v](); }
void PF(bool v) { PFV[v](); }
void HF(bool v) { HFV[v](); }
void ZF(bool v) { ZFV[v](); }
void SF(bool v) { SFV[v](); }

UINT8 REG8(UINT8 r)
{
	switch (r)
	{
		case 0: return *B;
		case 1: return *C;
		case 2: return *D;
		case 3: return *E;
		case 4: return *H;
		case 5: return *L;
		case 6: return RAM8(*HL);
		default:
		case 7: return *A;
	}
}

void REG8(UINT8 r, UINT8 v)
{
	switch (r)
	{
		case 0: *B = v; break;
		case 1: *C = v; break;
		case 2: *D = v; break;
		case 3: *E = v; break;
		case 4: *H = v; break;
		case 5: *L = v; break;
		case 6: RAM8(*HL, v); break;
		case 7: *A = v; break;
	}
}

UINT16 REG16(UINT8 p)
{
	switch (p)
	{
		case 0: return *BC;
		case 1: return *DE;
		default:
		case 2: return *HL;
		case 3: return *SP;
	}
}

void REG16(UINT8 p, UINT16 v)
{
	switch (p)
	{
		case 0: *BC = v; break;
		case 1: *DE = v; break;
		case 2: *HL = v; break;
		case 3: *SP = v; break;
	}
}

UINT16 RAM16(UINT16 a)
{
	return RAM8(a) | (RAM8(a + 1) << 8);
}

void RAM16(UINT16 a, UINT16 v)
{
	RAM8(a, v & 0xff);
	RAM8(a + 1, (v & 0xff00) >> 8);
}

UINT8 RAM8(UINT16 a)
{
	UINT8 r = RAM[a];
	RamCallback rcb = RAMMAP[a];
	if (rcb != READONLY && rcb != READWRITE)
		r = rcb(PEEK, a, r);
	bRM = 1;
	UPDATE(a, r);
	return r;	
}

void RAM8(UINT16 a, UINT8 v)
{
	RamCallback rcb = RAMMAP[a];
	if (rcb == READONLY)
		v = RAM[a];
	else if(rcb != READWRITE)
		v = rcb(POKE, a, v);
	bWO = 1;
	UPDATE(a, v);
	RAM[a] = v;
}

void STATUSCALLBACK()
{
	if(doStatus)
		statusCallback(STATUS, STATE, running);
}

void UPDATE(UINT16 a, UINT8 d)
{
	if (!doStatus) return;
	for (int i = 0; i < 16; i++)
		if (a & (1 << i)) sA[i]++;
	for (int i = 0; i < 8; i++)
		if (d & (1 << i)) sD[i]++;
	if (*EI) (*sEI)++;
	if (*HLT) (*sHLT)++;
	if (bIN) (*sIN)++;
	if (bOUT) (*sOUT)++;
	if (bM1) (*sM1)++;
	if (bRM) (*sRM)++;
	if (!bWO) (*sWO)++;
	if (bSTK) (*sSTK)++;
	if (bINT) (*sINT)++;
	if (!running) (*sWAIT)++;
	(*sCNT)++;
	bIN = 0;
	bOUT = 0;
	bM1 = 0;
	bRM = 0;
	bWO = 0;
	bINT = 0;
}

void CLEARSTATUS()
{
	if (!doStatus) return;
	for (int i = 0; i < 16; i++)
		sA[i] = 0;
	for (int i = 0; i < 8; i++)
		sD[i] = 0;
	*sEI = 0;
	*sHLT = 0;
	*sIN = 0;
	*sOUT = 0;
	*sM1 = 0;
	*sRM = 0;
	*sWO = 0;
	*sSTK = 0;
	*sINT = 0;
	*sWAIT = 0;
	*sCNT = 0;
}

void PUSH(UINT16 v)
{
	*SP -= 2;
	bSTK = 1;
	RAM16(*SP, v);
	bSTK = 0;
}

UINT16 POP()
{
	bSTK = 1;
	UINT16 p = RAM16(*SP);
	bSTK = 0;
	*SP += 2;
	return p;
}

UINT8 NEXT8()
{
	return RAM8((*PC)++);
}

UINT16 NEXT16()
{
	return RAM8((*PC)++) | (RAM8((*PC)++) << 8);
}

void ZSP(UINT8 v)
{
	ZF(!v);
	SF(v & 128);
	PF(PARITY[v]);
}

UINT8 ADD(UINT8 v, bool CY)
{
	UINT16 r = (UINT16)v + (UINT16)*A + (UINT16)CY;
	CF(r > 255);
	r &= 0xff;
	HF((r ^ *A ^ v) & 16);
	ZSP((UINT8)r);
	return (UINT8)r;
}

UINT8 SUB(UINT8 v, bool BW)
{
	UINT8 r = ADD(~v, !BW);
	CFI();
	return r;
}

void INC(UINT8 r)
{
	UINT8 v = REG8(r) + 1;
	REG8(r, v);
	HF(!(v & 15));
	ZSP(v);
}

void DEC(UINT8 r)
{
	UINT8 v = REG8(r) - 1;
	REG8(r, v);
	HF((v & 15) != 15);
	ZSP(v);
}

UINT8 AND(UINT8 v)
{
	UINT8 r = *A & v;
	ZSP(r);
	CF0();
	HF((*A | v) & 8);
	return r;
}

UINT8 OR(UINT8 v)
{
	UINT8 r = *A | v;
	ZSP(r);
	CF0();
	HF0();
	return r;
}

UINT8 XOR(UINT8 v)
{
	UINT8 r = *A ^ v;
	ZSP(r);
	CF0();
	HF0();
	return r;
}

static BoolCall CTABLE[8] = { ZFN, ZF, CFN, CF, PFN, PF, SFN, SF };

bool COND(UINT8 val)
{
	return CTABLE[val]();
}

void RESET(bool hard)
{
	bool oldRunning = running; // save old running state
	Stop(); // enter stepping mode
	requestEI = 0; // clear any request to enable interrupts
	int end = hard ? 65792 : 256; // we clear all ram as well if this is a hard reset
	for (int i = 0; i < end; i++) // clear all REGs (and memory for a hard reset)
		STATE[i] = 0;
	if (oldRunning && !hard) // if we were previously running and this is not a hard reset
		running = TRUE; // start running again
	else
		updatedPC = 1; // otherwise trigger a PC change detection
}

static UINT8 RRR0(UINT8 v)
{
	return v & 7;
}

static UINT8 RRR3(UINT8 v)
{
	return (v >> 3) & 7;
}

static UINT8 PP4(UINT8 v)
{
	return (v >> 4) & 3;
}

UINT8 NEXTOP()
{
	incPC = 0; // clear the increment PC flag
	bM1 = 1; // set instruction fetch status
	UINT8 op; // proto opcode
	if (*EI && *IV) // check if interrupts are enabled and there is a pending interrupt
	{
		bINT = 1; // set INT ACK status
		op = *IV; // set the opcode to the interrupt vector
		*HLT = 0; // clear HLT state
		*IV = 0; // clear the interrupt vector
		*EI = 0; // disable interrupts
		UPDATE(*PC, op); // update status because there's no memory access
	}
	else if (*HLT) // otherwise if we are in HLT state
	{
		op = 0; // set opcode to no operation (NOP)
		tsCount += 1000; // prevent CPU racing too much
		UPDATE(0xffff, 0xff); // update status because there's no memory access
	}
	else
	{
		op = RAM8(*PC); // otherwise we can set the opcode to the next instruction on the PC
		incPC = 1; // set the PC to increment, we don't increment yet because status would show the PC one more that it should be
	}
	tsCount += OP_TCOUNT[op]; // update the total t state counter
	timerCount += OP_TCOUNT[op]; // update the pause timer counter (timing pauses are only checked for every so many t states)
	return op; // return the opcode
}

void LOOP()
{
	DWORD waitResult = 1; // has to be non zero so the loop initally runs
	/*
	* Timing Pauses are accomplished by attempting to signal a mutex that is already signalled by another thread (the initializing thread)
	* this means the signal should never occur and the timeout delay will always occur.
	* However, if we do manage to signal the mutex, that means the mutex has been released by the initializing thread indicating that
	* we are shutting down. WaitForSingleObject will return 0 if we do manage to signal the mutex, so we loop until this happens.
	* This is why initialization must be run from a different thread to start.
	*/
	UINT8 op = 0;
	while (waitResult > 0) // loop until shutdown
	{
		if (running) // check if we're running
		{
			op = NEXTOP(); // get the next operation
			if (timerCount >= 1000 && speed > 1) // only check for a timing pause every 1000 tstates and if speed is not set to 1, a speed of 1 means "flat out" so there's no need to check for a pause
			{
				UINT64 now = timeGetTime(); // get the current system time in milliseconds
				if (now < startTime) // if the current time is less than the time when we started then timeGetTime() has looped around so deal with that or the emulation will kick into full speed
				{
					startTime = 0; // set the start time to 0
					tsCount = 0; // reset the t state counter
				}
				UINT64 real = now - startTime; // get the actual amount of milliseconds since the emulator started running
				UINT64 emu = ((tsCount * speed) / 1000000); // get the amount of emulated milliseconds that should have passed since the emulator started running
				if (emu > real) // if the emulated milliseconds are ahead of real milliseconds
				{
					STATUSCALLBACK(); // report cumulative status
					CLEARSTATUS(); // clear cumulative status
					waitResult = WaitForSingleObject(pauseMutex, 10); // pause for a short time and don't reset the 1000 tstate counter yet
				}
				else
					timerCount = 0; // emulator time is behind real time now so reset the 1000 tstate counter				
			}
		}
		else // otherwise we're stepping
		{			
			updatedPC = 1; // always trigger the PC changed detection on the first step loop
			do
			{
				stepping = 1; // indicate we are waiting for a step
				if (updatedPC) // first step loop or if the PC has changed due to a reset or examine
				{
					CLEARSTATUS(); // clear status info for one shot status update
					op = NEXTOP(); // get the opcode at the new PC which will also set the status info
					STATUSCALLBACK(); // report new one shot status
					updatedPC = 0; // clear the PC changed detection
				}
				waitResult = WaitForSingleObject(pauseMutex, 100); // pause for 0.1 seconds
			} while (!step && waitResult > 0 && !running); // loop until a step has been triggered, the mutex is signalled (shutdown) or set to running mode
			stepping = 0; // clear stepping indicator
			step = 0; // clear the step flag
			// the following line may seem redundant but it's not. While stepping, the system pauses after fetching the next instruction
			// this is necessary in order to update the correct status, however during this pause, the user may have changed the PC,
			// changed the RAM at the PC, set an interrupt condition or anything else that would change the instruction about to be executed
			// so we need to fetch it again. But ONLY if the op was a normal PC instruction
			if (incPC) op = NEXTOP();
		}
		if (incPC) (*PC)++; // increment the PC if needed
		EXECUTE(op); // execute the opcode
	}
	ReleaseMutex(pauseMutex); // if we get here, we've actually signalled the mutex telling us we're shutting down, so release the mutex we just signalled
}

void EXECUTE(UINT8 op)
{
	currentOP = op;
	switch(op)
	{
		case 0x3a: // LDA
			*A = RAM8(NEXT16());
			break;
		case 0x32: // STA
			RAM8(NEXT16(), *A);;
			break;
		case 0x2a: // LHLD
			*HL = RAM16(NEXT16());
			break;
		case 0x22: // SHLD
			RAM16(NEXT16(), *HL);
			break;
		case 0x0A: // LDAX BC
			*A = RAM8(*BC);
			break;
		case 0x1A: // LDAX DE
			*A = RAM8(*DE);
			break;
		case 0x02: // STAX BC
			RAM8(*BC, *A);
			break;
		case 0x12: // STAX DE
			RAM8(*DE, *A);
			break;
		case 0xEB: { // XCHG			
			UINT16 tmp = *HL;
			*HL = *DE;
			*DE = tmp;
			} break;
		case 0xC6: // ADI
			*A = ADD(NEXT8(), 0);
			break;
		case 0xCE: // ACI
			*A = ADD(NEXT8(), CF());
			break;
		case 0xD6: // SUI
			*A = SUB(NEXT8(), 0);
			break;
		case 0xDE: // SBI
			*A = SUB(NEXT8(), CF());
			break;
		case 0x27: { // DAA  (or "DAAAAAARGHHHHHH!!")			
			bool ncf = CF();
			UINT8 daa;
			switch ((HF() << 1) | (UINT8)CF())
			{
				default:
				case 3: daa = 0x66; break;
				case 2: daa = *A >= 0x9a ? 0x66 : 6; break;
				case 1: daa = (*A & 15) >= 0xa ? 0x66 : 0x60; break;
				case 0: daa = (*A >= 0x9a ? 0x60 : 0) + ((*A & 15) >= 0xa ? 6 : 0); break;
			}
			*A = ADD(daa, 0);
			CF(daa >= 0x60 || ncf); 
			} break;
		case 0xE6: // ANI
			*A = AND(NEXT8());
			break;
		case 0xEE: // XRI
			*A = XOR(NEXT8());
			break;
		case 0xF6: // ORI
			*A = OR(NEXT8());
			break;
		case 0xFE: // CPI
			SUB(NEXT8(), false);
			break;
		case 0x07: // RLC
			CF(*A & 0x80);
			*A = (*A << 1) | (UINT8)CF();
			break;
		case 0x0F: // RRC
			CF(*A & 1);
			*A = (*A >> 1) | (CF() << 7);
			break;
		case 0x17: { // RAL
			UINT8 LCF = *A >> 7;
			*A = (*A << 1) | (UINT8)CF();
			CF(LCF);
		}	break;
		case 0x1F: { // RAR
			UINT8 RCF = *A & 1;
			*A = (*A >> 1) | (CF() << 7);
			CF(RCF);
		}	break;
		case 0x2F: // CMA
			*A = ~*A;
			break;
		case 0x3F: // CMC
			CFI();
			break;
		case 0xC3: case 0xCB: // JMP
			*PC = NEXT16();
			break;
		case 0xCD: case 0xDD: case 0xED: case 0xFD: { // CALL
			UINT16 call = NEXT16();
			PUSH(*PC);
			*PC = call;
		}	break;
		case 0xC9: case 0xD9: // RET
			*PC = POP();
			break;
		case 0xE9: // PCHL
			*PC = *HL;
			break;
		case 0xF5: // PUSH PSW
			PUSH((*AF | 2) & 0xffd7);
			break;
		case 0xF1: // POP PSW
			*AF = (POP() | 2) & 0xffd7;
			break;
		case 0xC5: // PUSH BC
			PUSH(*BC);
			break;
		case 0xC1: // POP BC
			*BC = POP();
			break;
		case 0xD5: // PUSH DE
			PUSH(*DE);
			break;
		case 0xD1: // POP DE
			*DE = POP();
			break;
		case 0xE5: // PUSH HL
			PUSH(*HL);
			break;
		case 0xE1: // POP HL
			*HL = POP();
			break;
		case 0xE3: { // XTHL
			UINT16 _HL = *HL;
			*HL = RAM16(*SP);
			RAM16(*SP, _HL);
		}	break;
		case 0xF9: {// SPHL
			*SP = *HL;
		}	break;
		case 0xDB: { // IN
			UINT8 p = NEXT8(); // get the next byte from the PC, this is the port number
			bIN = 1; // set IN status
			*A = portInCallback(p); // send back to the app to request a port read and shove the result in the A register
			UPDATE(p | (p << 8), *A); // do an update as this is not memory access
		}	break;
		case 0xD3: { // OUT
			UINT8 p = NEXT8(); // get the next byte from the PC, this is the port number
			bOUT = 1; // set OUT status
			portOutCallback(p, *A); // send back to the app to request a port write using the A register as the data being sent to the port
			UPDATE(p | (p << 8), *A); // do an update as this is not memory access
		}	break;
		case 0xFB: // EI
			requestEI = 1; // don't enable interrupts right away, signal a request to do so
			return; // we return instead of breaking so the check for the request is not done on this cycle, this allows a RET to execute after EI at the end of an interrupt routine
		case 0xF3: // DI
			*EI = 0;
			break;
		case 0x76: // HLT
			*HLT = 1;
			break;
		case 0x37: // STC
			CF1();
			break;
		case 0x00: case 0x10: case 0x20: case 0x30: case 0x08: case 0x18: case 0x28: case 0x38: // NOP
			break;
		case 0x40: case 0x41: case 0x42: case 0x43: case 0x44: case 0x45: case 0x46: case 0x47: // MOV
		case 0x48: case 0x49: case 0x4a: case 0x4b: case 0x4c: case 0x4d: case 0x4e: case 0x4f:
		case 0x50: case 0x51: case 0x52: case 0x53: case 0x54: case 0x55: case 0x56: case 0x57:
		case 0x58: case 0x59: case 0x5a: case 0x5b: case 0x5c: case 0x5d: case 0x5e: case 0x5f:
		case 0x60: case 0x61: case 0x62: case 0x63: case 0x64: case 0x65: case 0x66: case 0x67:
		case 0x68: case 0x69: case 0x6a: case 0x6b: case 0x6c: case 0x6d: case 0x6e: case 0x6f:
		case 0x70: case 0x71: case 0x72: case 0x73: case 0x74: case 0x75: case 0x77:
		case 0X78: case 0x79: case 0x7a: case 0x7b: case 0x7c: case 0x7d: case 0x7e: case 0x7f:
			REG8(RRR3(op), REG8(RRR0(op)));
			break;
		case 0x06: case 0x0e: case 0x16: case 0x1e: case 0x26: case 0x2e: case 0x36: case 0x3e: // MVI
			REG8(RRR3(op), NEXT8());
			break;
		case 0x01: case 0x11: case 0x21: case 0x31: // LXI
			REG16(PP4(op), NEXT16());
			break;
		case 0x80: case 0x81: case 0x82: case 0x83: case 0x84: case 0x85: case 0x86: case 0x87: // ADD
		case 0x88: case 0x89: case 0x8a: case 0x8b: case 0x8c: case 0x8d: case 0x8e: case 0x8f: // ADC
			*A = ADD(REG8(RRR0(op)), (op & 8) && CF());
			break;
		case 0x90: case 0x91: case 0x92: case 0x93: case 0x94: case 0x95: case 0x96: case 0x97: // SUB
		case 0x98: case 0x99: case 0x9a: case 0x9b: case 0x9c: case 0x9d: case 0x9e: case 0x9f: // SBB
			*A = SUB(REG8(RRR0(op)), (op & 8) && CF());
			break;
		case 0xb8: case 0xb9: case 0xba: case 0xbb: case 0xbc: case 0xbd: case 0xbe: case 0xbf: // CMP
			SUB(REG8(RRR0(op)), false);
			break;
		case 0x04: case 0x0c: case 0x14: case 0x1c: case 0x24: case 0x2c: case 0x34: case 0x3c: // INR
			INC(RRR3(op));
			break;
		case 0x05: case 0x0d: case 0x15: case 0x1d: case 0x25: case 0x2d: case 0x35: case 0x3d: // INR
			DEC(RRR3(op));
			break;
		case 0x03: case 0x13: case 0x23: case 0x33: { // INX
			UINT8 irp = PP4(op);
			REG16(irp, REG16(irp) + 1);
		}	break;
		case 0x0b: case 0x1b: case 0x2b: case 0x3b: { // DCX
			UINT8 drp = PP4(op);
			REG16(drp, REG16(drp) - 1);
		}	break;
		case 0x09: case 0x19: case 0x29: case 0x39: { // DAD
			UINT32 nhl = (UINT32)*HL + (UINT32)REG16(PP4(op));
			*HL = nhl & 0xffff;
			CF(nhl > 65535);
		}	break;
		case 0xa0: case 0xa1: case 0xa2: case 0xa3: case 0xa4: case 0xa5: case 0xa6: case 0xa7: // ANA
			*A = AND(REG8(RRR0(op)));
			break;
		case 0xa8: case 0xa9: case 0xaa: case 0xab: case 0xac: case 0xad: case 0xae: case 0xaf: // XRA
			*A = XOR(REG8(RRR0(op)));
			break;
		case 0xb0: case 0xb1: case 0xb2: case 0xb3: case 0xb4: case 0xb5: case 0xb6: case 0xb7: // ORA
			*A = OR(REG8(RRR0(op)));
			break;
		case 0xc2: case 0xd2: case 0xe2: case 0xf2: // JNZ JNC JPO JP   (JCND)
		case 0xca: case 0xda: case 0xea: case 0xfa: { // JZ JC JPE JM
			UINT16 jcnd = NEXT16();
			if (COND(RRR3(op)))
			{
				tsCount += 6;
				*PC = jcnd;
			}
		}	break;
		case 0xc0: case 0xd0: case 0xe0: case 0xf0: // RNZ RNC RPO RP   (RCND)
		case 0xc8: case 0xd8: case 0xe8: case 0xf8: // RZ RC RPE RM
			if (COND(RRR3(op)))
				*PC = POP();
			break;
		case 0xc4: case 0xd4: case 0xe4: case 0xf4: // CNZ CNC CPO CP   (CCND)
		case 0xcc: case 0xdc: case 0xec: case 0xfc: { // CZ CC CPE CM
			UINT16 ccnd = NEXT16();
			if (COND(RRR3(op)))
			{
				tsCount += 6;
				PUSH(*PC);
				*PC = ccnd;
			}
		}	break;
		case 0xc7: case 0xd7: case 0xe7: case 0xf7: // RST 0 2 4 6
		case 0xcf: case 0xdf: case 0xef: case 0xff: // RST 1 3 5 7
			PUSH(*PC);
			*PC = RRR3(op) * 8;
			break;
	}
	if (requestEI)
	{
		*EI = 1;
		requestEI = 0;
	}	
}

