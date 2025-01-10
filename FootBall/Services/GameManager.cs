using FootBall.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FootBall.Services
{
    public class GameManager//המחלקה תנהל את המשחק בין היתר היא תיצור את כל הדמויות
    {
        private Canvas _field;
        private List<GameObject> _gameObjects;
        private DispatcherTimer _runTimer;
        public GameManager(Canvas field)
        
        {
            _runTimer = new DispatcherTimer();
            _runTimer.Interval=TimeSpan.FromMilliseconds(1);
            _runTimer.Start();
            _runTimer.Tick+=_runTimer_Tick;


            _field = field;
            _gameObjects = new List<GameObject>();
            _gameObjects.Add(new Goal(10,220, Goal.DirectionType.Left, _field, 50));
            _gameObjects.Add(new Goal(_field.ActualWidth-10-50, 220, Goal.DirectionType.Right, _field, 50));
            _gameObjects.Add(new Ball(400,200,"Ball/Ball.png",_field,50));
            CreateFans();
        }

        private void _runTimer_Tick(object sender, object e)
        {
            foreach(GameObject obj in _gameObjects)
            {
                if (obj is GameMovingObject moveObj)
                    moveObj.Render();
            }
        }

        private void CreateFans()
        {
            Random random = new Random();
            int x=10;
            int y=-30;
            double y2=_field.ActualHeight;

            for(int i=0; i < 17; i++)
            {
                _gameObjects.Add(new Fan(x,y,  _field, 80, (Fan.side)random.Next(2)));
                _gameObjects.Add(new Fan(x,y2-60,  _field, 80, (Fan.side)random.Next(2)));
                x += 55;
            }

        }
    }
}

