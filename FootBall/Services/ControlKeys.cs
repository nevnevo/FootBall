using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace FootBall.Services
{
    public class ControlKeys
    {
        //Left Player Keys:
        public static VirtualKey LeftPlayerGoAhead { get; set; } = VirtualKey.D;

        public static VirtualKey LeftPlayerGoBack { get; set; } = VirtualKey.A;

        public static VirtualKey LeftPlayerGoUp { get; set; } = VirtualKey.W;

        public static VirtualKey LeftPlayerGoDown { get; set; } = VirtualKey.S;

        //Right Player Keys:
        public static VirtualKey RightPlayerGoAhead { get; set; } = VirtualKey.Left;

        public static VirtualKey RightPlayerGoBack { get; set; } = VirtualKey.Right;

        public static VirtualKey RightPlayerGoUp { get; set; } = VirtualKey.Up;

        public static VirtualKey RightPlayerGoDown { get; set; } = VirtualKey.Down;
    }
}
