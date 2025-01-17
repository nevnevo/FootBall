using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace FootBall.Objects
{
    public abstract class Player : GameMovingObject
    {
        public Player(double x, double y, string fileName, Canvas field, double size) : base(x, y, fileName, field, size)
        {
        }
    }
}
