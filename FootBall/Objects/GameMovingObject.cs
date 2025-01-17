using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace FootBall.Objects
{
    public abstract class GameMovingObject : GameObject
    {
        protected double _speedX;
        protected double _speedY;
        protected double _accelerationX;
        protected double _accelerationY;
      

        //המחלקה מהווה בסיס לכל העצמים שאמורים לנוע
        protected GameMovingObject(double x, double y, string fileName, Canvas field, double size) : base(x, y, fileName, field, size)
        {
            Stop();
        }
        public override void Render()//הפעולה צריכה להתבצע ללא הפסקה עבור כל הדמויות הנעות
        {
            _x += _speedX;///שינוי מיקום
            _y += _speedY;
            _speedX += _accelerationX;//שינוי מהירות
            _speedY += _accelerationY;


            base.Render();              //מציירת את הדמות במיקום החדש
        } 
        private void Stop()
        {
            _speedX = 0;
            _speedY = 0;
            _accelerationX = 0;
            _accelerationX = 0;
    }

        
    }
}
