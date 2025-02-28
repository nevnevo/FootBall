using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace FootBall
{//המחלקה לא מיועדת ליצרת עצמים, אלא היא תהווה בסיס, אב קדמון לכל המחלקות היורשות ממנה
//המחלקה תכלול את המכנה המשותף לכל המחלקות העתידיות
    public abstract class GameObject
    {
        protected double _x;//מיקום אופקי
        protected double _y;//מיקום אנכי
        protected Image _objectImage;
        protected Canvas _field;

        public bool Collisional { get; set; } = true;

        public GameObject(double x,double y,string fileName ,Canvas field,double size)
        {
            _x = x;
            _y = y;
            _objectImage = new Image();
            _objectImage.Width = size; //כך קובעים את גודל התמונה
            _field = field;
            SetImage(fileName);//כך קובעים את שם התמונה
            _field.Children.Add(_objectImage);//הדמות תופיע על המגרש
            Render();
        }

        public virtual void Render()//הפעולה קובעת את מיקום הדמות ביחס לשולי הקנבס
        {
            
            Canvas.SetLeft(_objectImage, _x);
            Canvas.SetTop(_objectImage, _y);
        }

        public virtual Rect Rect()
        {
            return new Rect(_x, _y, _objectImage.Width, _objectImage.Height);
        }

        protected void SetImage(string fileName)
        {
            _objectImage.Source = new BitmapImage(new Uri($"ms-appx:///Assets/{fileName}"));
        }
        public virtual void Collide(GameObject otherObject)
        {

        }
    }
}
