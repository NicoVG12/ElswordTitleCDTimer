using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
    public class UserActionKeys
    {
        public short TitleSwitchKey { get; set; }
        public short TopTitleKey { get; set; }
        public short BottomTitleKey { get; set; }
        public short LeftTitleKey { get; set; }
        public short RightTitleKey { get; set; }

        public short AwakeningKey { get; set; }
        public short OnionKey { get; set; }
        public short OnionKeyAlt { get; set; }

        public IEnumerable<short> SkillKeys { get; set; } = new List<short>();

        public UserActionKeys() { }

        public UserActionKeys(bool _default)
        {
            TitleSwitchKey = 0x14;
            TopTitleKey = 0x26;
            BottomTitleKey = 0x28;
            LeftTitleKey = 0x25;
            RightTitleKey = 0x27;
            AwakeningKey = 0xA2;
            OnionKey = 0x34;
            OnionKeyAlt = 0x34;
            SkillKeys = new List<short>()
            {
                0x51, 0x57, 0x45, 0x52, 0x54, 0x41, 0x53, 0x44, 0x46, 0x43
            };
        }
    }
}
