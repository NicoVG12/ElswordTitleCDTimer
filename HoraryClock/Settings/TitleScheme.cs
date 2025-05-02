using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
    public class TitleScheme
    {
        public const int NoTitle = -1;
        public const int AwkDmgTitle = 0;
        public const int MainTitle = 1;
        public const int AwkCDrTitle = 2;
        public const int ResetSkillTitle = 3;

        public int TopTitle {  get; set; }
        public int BottomTitle { get; set; }
        public int LeftTitle { get; set; }
        public int RightTitle { get; set; }

        public TitleScheme()
        {
            TopTitle = NoTitle;
            BottomTitle = NoTitle;
            LeftTitle = NoTitle;
            RightTitle = NoTitle;
        }
    }
}
