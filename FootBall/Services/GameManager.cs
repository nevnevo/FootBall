using FootBall.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace FootBall.Services
{
    public class GameManager//המחלקה תנהל את המשחק בין היתר היא תיצור את כל הדמויות
    {
        private Canvas _field;
        private List<GameObject> _gameObjects;
        public GameManager(Canvas field)
        {
            _field = field;
            _gameObjects = new List<GameObject>();
            _gameObjects.Add(new Goal(10,220, Goal.DirectionType.Left, _field, 50));
            _gameObjects.Add(new Goal(_field.ActualWidth-10-50, 220, Goal.DirectionType.Right, _field, 50));

        }
    }
}
