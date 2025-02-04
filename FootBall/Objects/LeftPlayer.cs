using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml.Controls;

namespace FootBall.Objects
{
    public class LeftPlayer : Player
    {
        public LeftPlayer(double x, double y, string fileName, Canvas field, double size) : base(x, y, fileName, field, size)
        {
            _objectImage.Height = size * 1.536;
        }
        protected override void Move(VirtualKey key)
        {
            if()
        }
    }
}
