using Nicsure.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nicsure.Intel8080
{
    // Code by nicsure (C)2022
    // https://www.youtube.com/nicsure

    public static class Disassembler
    {
        public static String Get(int addr, byte[] state)
        {
            int op = state.GetByte(addr);
            String d = "NOP : NO OPERATION";
            int l = (addr + 1) & 0xffff;
            switch (op)
            {
                case 0x3a: // LDA
                    d = "LDA : A <= [" + l.X4() + "] # " + state.GetByte(l).X2();
                    break;
                case 0x32: // STA
                    d = "STA : [" + l.X4() + "] <= A";
                    break;
                case 0x2a: // LHLD
                    d = "LHLD : HL <= [" + l.X4() + "] # " + state.GetWord(l).X4();
                    break;
                case 0x22: // SHLD
                    d = "SHLD : [" + l.X4() + "] <= HL";
                    break;
                case 0x0A: // LDAX BC
                    d = "LDAX : A <= [BC]";
                    break;
                case 0x1A: // LDAX DE
                    d = "LDAX : A <= [DE]";
                    break;
                case 0x02: // STAX BC
                    d = "STAX : [BC] <= A";
                    break;
                case 0x12: // STAX DE
                    d = "STAX : [DE] <= A";
                    break;
                case 0xEB: // XCHG
                    d = "XCHG : HL <=> DE";
                    break;
                case 0xC6: // ADI
                    d = "ADI : A <= A + [" + l.X4() + "] # " + state.GetByte(l).X2();
                    break;
                case 0xCE: // ADC
                    d = "ADC : A <= A + [" + l.X4() + "] + CF # " + state.GetByte(l).X2();
                    break;
                case 0xD6: // SUI
                    d = "SUI : A <= A - [" + l.X4() + "] # " + state.GetByte(l).X2();
                    break;
                case 0xDE: // SBC
                    d = "SBC : A <= A - [" + l.X4() + "] - CF # " + state.GetByte(l).X2();
                    break;
                case 0x27: // DAA
                    d = "DAA : A <= BCD(A)";
                    break;
                case 0xE6: // ANI
                    d = "ANI : A <= A & [" + l.X4() + "] # " + state.GetByte(l).X2();
                    break;
                case 0xEE: // XRI
                    d = "XRI : A <= A ^ [" + l.X4() + "] # " + state.GetByte(l).X2();
                    break;
                case 0xF6: // ORI
                    d = "ORI : A <= A | [" + l.X4() + "] # " + state.GetByte(l).X2();
                    break;
                case 0xFE: // CPI
                    d = "CPI : A CMP [" + l.X4() + "] ? # " + state.GetByte(l).X2();
                    break;
                case 0x07: // RLC
                    d = "RLC : A <= <<A # CF = MSb(A)";
                    break;
                case 0x0F: // RRC
                    d = "RRC : A <= A>> # CF = LSb(A)";
                    break;
                case 0x17: // RAL
                    d = "RAL : A = <<A + CF # CF = MSb(A)";
                    break;
                case 0x1F: // RAR
                    d = "RAR : A <= CF<<7 + A>> # CF = LSb(A)";
                    break;
                case 0x2F: // CMA
                    d = "CMA : A <= ~A";
                    break;
                case 0x3F: // CMC
                    d = "CMC : CF <= ~CF";
                    break;
                case 0xC3: // JMP
                case 0xCB:
                    d = "JMP : PC <= " + state.GetWord(l).X4();
                    break;
                case 0xCD: // CALL
                case 0xDD:
                case 0xED:
                case 0xFD:
                    d = "CALL : SP <= SP - 2; [SP] <= PC; PC <= " + state.GetWord(l).X4();
                    break;
                case 0xC9: // RET
                case 0xD9:
                    d = "RET : PC <= [SP]; SP <= SP + 2";
                    break;
                case 0xE9: // PCHL
                    d = "PCHL : PC <= HL";
                    break;
                case 0xF5: // PUSH PSW
                    d = "PUSH PSW : SP <= SP - 2; [SP] <= AF";
                    break;
                case 0xF1: // POP PSW
                    d = "POP PSW : AF <= [SP]; SP <= SP + 2";
                    break;
                case 0xC5: // PUSH BC
                    d = "PUSH BC : SP <= SP - 2; [SP] <= BC";
                    break;
                case 0xC1: // POP BC
                    d = "POP BC : BC <= [SP]; SP <= SP + 2";
                    break;
                case 0xD5: // PUSH DE
                    d = "PUSH DE : SP <= SP - 2; [SP] <= DE";
                    break;
                case 0xD1: // POP DE
                    d = "POP DE : DE <= [SP]; SP <= SP + 2";
                    break;
                case 0xE5: // PUSH HL
                    d = "PUSH HL : SP <= SP - 2; [SP] <= HL";
                    break;
                case 0xE1: // POP HL
                    d = "POP HL : HL <= [SP]; SP <= SP + 2";
                    break;
                case 0xE3: // XTHL
                    d = "XTHL : HL <=> [SP]";
                    break;
                case 0xF9: // SPHL
                    d = "SPHL : SP <= HL";
                    break;
                case 0xDB: // IN#
                    d = "IN : A <= PORT[" + state.GetByte(l).X2() + "]";
                    break;
                case 0xD3: // OUT
                    d = "OUT : PORT[" + state.GetByte(l).X2() + "] <= A";
                    break;
                case 0xFB: // EI
                    d = "EI : INTS ENABLE";
                    break;
                case 0xF3: // DI
                    d = "DI : INTS DISABLE";
                    break;
                case 0x76: // HLT
                    d = "HLT : HALT";
                    break;
                case 0x37: // STC
                    d = "STC : CF <= 1";
                    break;
                case int n when (n != 0x76 && n >= 0x40 && n <= 0x7f): // MOV
                    d = "MOV : " + op.R3() + " <= " + op.R0();
                    break;
                case int n when ((n & 0xc7) == 6): // MVI
                    d = "MVI : " + op.R3() + " <= " + state.GetByte(l).X2();
                    break;
                case int n when ((n & 0xcf) == 1): // LXI
                    d = "LXI : " + op.PP() + " <= " + state.GetWord(l).X4();
                    break;
                case int n when ((n & 0xf0) == 0x80): // ADD and ADC
                    d = "ADD : A <= A + " + op.R0() + (((op & 8) >> 3) == 1 ? " + CF" : String.Empty);
                    break;
                case int n when ((n & 0xf0) == 0x90): // SUB and SBB
                    d = "SUB : A <= A - " + op.R0() + (((op & 8) >> 3) == 1 ? " - CF" : String.Empty);
                    break;
                case int n when ((n & 0xf8) == 0xb8): // CMP
                    d = "CMP : A == " + op.R0();
                    break;
                case int n when ((n & 0xc7) == 4): // INR
                    d = "INR : " + op.R3() + " <= " + op.R3() + " + 1";
                    break;
                case int n when ((n & 0xc7) == 5): // DCR
                    d = "DCR : " + op.R3() + " <= " + op.R3() + " - 1";
                    break;
                case int n when ((n & 0xcf) == 3): // INX
                    d = "INX : " + op.PP() + " <= " + op.PP() + " + 1";
                    break;
                case int n when ((n & 0xcf) == 11): // DCX
                    d = "DCX : " + op.PP() + " <= " + op.PP() + " - 1";
                    break;
                case int n when ((n & 0xcf) == 9): // DAD
                    d = "DAD : HL <= HL + " + op.PP();
                    break;
                case int n when ((n & 0xf8) == 0xa0): // ANA
                    d = "ANA : A <= A & " + op.R0();
                    break;
                case int n when ((n & 0xf8) == 0xa8): // XRA
                    d = "XRA : A <= A ^ " + op.R0();
                    break;
                case int n when ((n & 0xf8) == 0xb0): // ORA
                    d = "ORA : A <= A | " + op.R0();
                    break;
                case int n when ((n & 0xc7) == 0xc2): // JCND
                    d = "JMP : JUMP IF " + op.CC() + " " + state.GetWord(l).X4();
                    break;
                case int n when ((n & 0xc7) == 0xc0): // RCND
                    d = "RET : RETURN IF " + op.CC();
                    break;
                case int n when ((n & 0xc7) == 0xc4): // CCND
                    d = "CALL : CALL IF " + op.CC() + " " + state.GetWord(l).X4();
                    break;
                case int n when ((n & 0xc7) == 0xc7): // RST
                    d = "RST : RESTART " + op.RS();
                    break;
            }
            return d;
        }

        private static int GetByte(this byte[] b, int addr) => b[(addr & 0xffff) + 0x100];

        private static int GetWord(this byte[] b, int addr) =>
             b[(addr & 0xffff) + 0x100] | (b[((addr + 1) & 0xffff) + 0x100] << 8);

        private static String RS(this int i)
        {
            return ((i >> 3) & 7) switch
            {
                1 => "0008",
                2 => "0010",
                3 => "0018",
                4 => "0020",
                5 => "0028",
                6 => "0030",
                7 => "0038",
                _ => "0000",
            };
        }

        private static String CC(this int i)
        {
            return ((i >> 3) & 7) switch
            {
                1 => "ZERO",
                2 => "NO CARRY",
                3 => "CARRY",
                4 => "NO PARITY",
                5 => "PARITY",
                6 => "POSITIVE",
                7 => "NEGATIVE",
                _ => "NOT ZERO",
            };
        }

        private static String PP(this int i)
        {
            return ((i >> 4) & 3) switch
            {
                1 => "DE",
                2 => "HL",
                3 => "SP",
                _ => "BC",
            };
        }

        private static String R3(this int i) => (i >> 3).R0();
        private static String R0(this int i)
        {
            return (i & 7) switch
            {
                1 => "C",
                2 => "D",
                3 => "E",
                4 => "H",
                5 => "L",
                6 => "[HL]",
                7 => "A",
                _ => "B",
            };
        }


    }
}
