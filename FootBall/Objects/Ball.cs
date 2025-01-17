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
            
            _speedX = 5;

            _speedY = -5;
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
        }

    }
}