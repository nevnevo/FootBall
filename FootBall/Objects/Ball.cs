using FootBall.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace FootBall.Objects
{



    public class Ball : GameMovingObject

    {
        private Random rnd = new Random();
        public Ball(double x, double y, string fileName, Canvas field, double size) : base(x, y, fileName, field, size)
        {
            
            _speedX = 0;

            _speedY = 0;
            _objectImage.Height = size;
            

        }

        public override void Render()
        {
            base.Render();
            if (_x <= 0 || _x + _objectImage.Width >= _field.ActualWidth)
            {
                _speedX *= -1;

            }
            if (_y <= 0 || _y + _objectImage.Height >= _field.ActualHeight)
            {
                _speedY *= -1;

            }
            if (_speedX != 0)
            {
                _accelerationX = -_speedX / Math.Abs(_speedX);
                _accelerationX *= Constants.AccelerationBall;
            }
            else
                _accelerationX = 0;
            if (_speedY != 0)
            {
                _accelerationY = -(_speedY / (Math.Abs(_speedY))) * Constants.AccelerationBall;
            }
            else
                _accelerationY = 0;

            if(Math.Abs)
        }

        public void SetSpeed(double speedX, double speedY)
        {
            _x += speedX;
            _y += speedY;

            _speedX = speedX * Constants.KickStrength;
            _speedY = speedY * Constants.KickStrength;
        }
    }
}