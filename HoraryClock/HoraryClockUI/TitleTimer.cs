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
        public Image CDImageSelected { get; set; }
        public Image ImageSelected { get; set; }
        public int TitleId;

        public const int ID_175 = 0;
        public const int ID_156 = 3;
        public const int ID_135 = 2;
        public const int ID_ORDER = 1;

        public TitleTimer(Label label, ClockManager timer, Image cDImage, Image image, Image cDImageSelected, Image imageSelected, int titleID)
        {
            Label = label;
            Timer = timer;
            CDImage = cDImage;
            Image = image;
            CDImageSelected = cDImageSelected;
            ImageSelected = imageSelected;
            TitleId = titleID;
        }
    }
}
