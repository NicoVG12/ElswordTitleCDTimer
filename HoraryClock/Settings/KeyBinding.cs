using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HoraryClock
{
    public class KeyBinding
    {
        public short Key17_5 { get; set; }
        public short Key15_6 { get; set; }
        public short Key13_5 { get; set; }
        public short KeyOrder { get; set; }
        public short KeyPauseAll { get; set; }
        public short KeyUnpauseAll { get; set; }
        public short KeyResetAll { get; set; }

        public KeyBinding()
        {
            Key13_5 = 0x72;
            Key15_6 = 0x71;
            Key17_5 = 0x70;
            KeyOrder = 0x73;

            KeyPauseAll = 0x7B;
            KeyUnpauseAll = 0x7A;
            KeyResetAll = 0x79;
        }
    }
}
