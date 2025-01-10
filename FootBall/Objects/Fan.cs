using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace FootBall.Objects
{
    public class Fan : GameObject
    {
        

        

        public enum side
        {
            LeftGoal, RightGoal
        }
        public side GoalSide { get; private set; }

        public Fan(double x, double y, Canvas field, double size, side FanSide) : base(x, y, string.Empty, field, size)
        {
            GoalSide = FanSide;
            if (FanSide == side.LeftGoal)
                SetImage("Fans/Fan1Img.png");
            else
            {
                SetImage("Fans/Fan2Img.png");
            }
        }
    }
}
