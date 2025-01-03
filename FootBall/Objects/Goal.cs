using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace FootBall.Objects
{
    public class Goal : GameObject
    {
        public enum DirectionType
        {
            Left,Right
        }
        public DirectionType Direction { get; private set; }
        public Goal(double x, double y,DirectionType direction, Canvas field, double size) : base(x, y, string.Empty, field, size)
        {
            Direction = direction;
            if (direction == DirectionType.Left)
            {
                SetImage("Goals/leftGoalImg.jpeg");
            }
            else
            {
                SetImage("Goals/RightGoalImg.jpeg");
            }

        }
    }
}
