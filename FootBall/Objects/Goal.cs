using FootBall.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI;
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
            _objectImage.Height = size * 2.42;
            if (direction == DirectionType.Left)
            {
                SetImage("Goals/leftGoalImg.jpeg");
                RectangleHelper.DrawRectangle(_field, _x + size - 10, y + 20, 5, _objectImage.Height - 40, Colors.OrangeRed);
            }
            else
            {
                SetImage("Goals/RightGoalImg.jpeg");
                RectangleHelper.DrawRectangle(_field, _x + 10, _y + 20, 5, _objectImage.Height - 40, Colors.OrangeRed);
            }

        }

        public override Rect Rect()
        {
            if(Direction == DirectionType.Left)
            {
                return new Rect(_x + _objectImage.Width - 30, _y + 20, 5, _objectImage.Height - 40);
            }
            return new Rect(_x + 20, _y + 20, 5, _objectImage.Height - 40);
        }

    }
}
