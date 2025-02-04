using FootBall.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml.Controls;

namespace FootBall.Objects
{
    public abstract class Player : GameMovingObject
    {
        public enum StateType
        {
            idle, runLeft, runRight
        }
        public StateType PlayerState { get; set; } = StateType.idle;
        public Player(double x, double y, string fileName, Canvas field, double size) : base(x, y, fileName, field, size)
        {
            //כך השחקנים נרשמים באירוע ולכן יוכלו להגיב גם באופן יחודי
            GameManager.GameEvents.OnKeyPress += Move;
            GameManager.GameEvents.OnKeyLeave += Relax;
        }

        protected virtual void Relax(VirtualKey obj)
        {
            
        }

        protected virtual void Move(VirtualKey obj)
        {
            
        }
    }
}
