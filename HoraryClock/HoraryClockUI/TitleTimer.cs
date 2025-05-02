using Clock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitleTimerUI
{
    internal class TitleTimer
    {
        public Label Label { get; set; }
        public ClockManager Timer;
        public Image CDImage { get; set; }
        public Image Image { get; set; }

        public const int ID_175 = 0;
        public const int ID_156 = 1;
        public const int ID_135 = 2;
        public const int ID_ORDER = 3;

        public TitleTimer(Label label, ClockManager timer, Image cDImage, Image image)
        {
            Label = label;
            Timer = timer;
            CDImage = cDImage;
            Image = image;
        }
    }
}
