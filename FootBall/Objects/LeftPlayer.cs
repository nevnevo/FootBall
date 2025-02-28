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
    public class LeftPlayer : Player
    {

        public LeftPlayer(double x, double y, string fileName, Canvas field, double size) : base(x, y, fileName, field, size)
        {
            _objectImage.Height = size * 1.536;
        }

        protected override void Move(VirtualKey key)
        {

            if (key == ControlKeys.LeftPlayerGoAhead)
                GoRight();
            if (key == ControlKeys.LeftPlayerGoBack)
                GoLeft();
            if (key == ControlKeys.LeftPlayerGoUp)
                GoUp();
            if (key == ControlKeys.LeftPlayerGoDown)
                GoDown();

        }

        protected override void Relax(VirtualKey key)
        {
            var state = PlayerState;
            if (key == ControlKeys.LeftPlayerGoAhead || key == ControlKeys.LeftPlayerGoBack)
                _speedX = 0;
            if (key == ControlKeys.LeftPlayerGoUp || key == ControlKeys.LeftPlayerGoDown)
                _speedY = 0;
            PlayerState = StateType.idle;
            if (state != PlayerState)
            {
                MatchImageToState();
            }

        }


       


        protected override void MatchImageToState()
        {
            switch (PlayerState)
            {
                case StateType.idle:SetImage("Players/Dog/DogIdle.gif");break;
                case StateType.runLeft:SetImage("Players/Dog/DogRunLeft.gif");break;
                case StateType.runRight:SetImage("Players/Dog/DogRun.gif");break;

            }
        }
        
    }
}
