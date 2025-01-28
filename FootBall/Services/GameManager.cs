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
        public static GameEvents GameEvents { get; private set; } = new GameEvents();
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
            _gameObjects.Add(new Ball(400,200,"Ball/ball2.png",_field,50));

            _gameObjects.Add(new LeftPlayer((_field.ActualWidth/2)+50, 200, "Players/Cat/CatIdle.gif", _field, 70));
            _gameObjects.Add(new LeftPlayer((_field.ActualWidth/2)-(70+50), 200, "Players/Dog/DogIdle.gif", _field, 70));
            CreateFans();

            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
            Window.Current.CoreWindow.KeyUp += CoreWindow_KeyUp;
        }

        private void CoreWindow_KeyUp(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            
        }

        private void CoreWindow_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
           if(GameEvents.OnKeyPress!=null)
            {
                
            }
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
            int y=-80;
            double y2=_field.ActualHeight;

            for(int i=0; i < 14; i++)
            {
                _gameObjects.Add(new Fan(x+(i*10),y,  _field, 80, (Fan.side)random.Next(2)));
                _gameObjects.Add(new Fan(x + (i * 10), y2-10,  _field, 80, (Fan.side)random.Next(2)));
                x += 55;
            }

        }
    }
}

