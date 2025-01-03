using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace FootBall
{//המחלקה לא מיועדת ליצרת עצמים, אלא היא תהווה בסיס, אב קדמון לכל המחלקות היורשות ממנה
//המחלקה תכלול את המכנה המשותף לכל המחלקות העתידיות
    public abstract class GameObject
    {
        private double _x;//מיקום אופקי
        private double _y;//מיקום אנכי
        private Image _objectImage;
        private Canvas _field;
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

        private void Render()//הפעולה קובעת את מיקום הדמות ביחס לשולי הקנבס
        {
            Canvas.SetLeft(_objectImage, _x);
            Canvas.SetTop(_objectImage, _y);
        }

        protected void SetImage(string fileName)
        {
            _objectImage.Source = new BitmapImage(new Uri($"ms-appx:///Assets/{fileName}"));
        }
    }
}
