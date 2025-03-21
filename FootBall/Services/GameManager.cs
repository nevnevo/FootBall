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
        public static Level Level { get; set; } = new Level();


        public GameManager(Canvas field)
        
        {
            _runTimer = new DispatcherTimer();
            _runTimer.Interval=TimeSpan.FromMilliseconds(1);
            _runTimer.Start();
            _runTimer.Tick+=_runTimer_Tick;



            
            _field = field;
            _gameObjects = new List<GameObject>();
            _gameObjects.Add(new Goal(10, ((_field.ActualHeight / 2) - Level.goalSize / 2)-50, Goal.DirectionType.Left, _field, Level.goalSize));
            _gameObjects.Add(new Goal(_field.ActualWidth-10-50, ((_field.ActualHeight / 2) - Level.goalSize / 2) - 50, Goal.DirectionType.Right, _field, Level.goalSize));
            _gameObjects.Add(new Ball(670,260,"Ball/ball2.png",_field,50));

            _gameObjects.Add(new RightPlayer((_field.ActualWidth/2)+50, 200, "Players/Cat/CatIdle.gif", _field, 70));
            _gameObjects.Add(new LeftPlayer((_field.ActualWidth/2)-(70+50), 200, "Players/Dog/DogIdle.gif", _field, 70));
            CreateFans();

            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
            Window.Current.CoreWindow.KeyUp += CoreWindow_KeyUp;
        }

        private void CoreWindow_KeyUp(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
            if (GameEvents.OnKeyLeave != null)
            {
                GameEvents.OnKeyLeave(args.VirtualKey);//האירוע שהגדרנו
            }
        }
        //הפעולה תתבצע באופן אוטומטי כאשר משתמש ילחץ על מקש כלשהו
        private void CoreWindow_KeyDown(Windows.UI.Core.CoreWindow sender, Windows.UI.Core.KeyEventArgs args)
        {
           if(GameEvents.OnKeyPress!=null)
            {
                GameEvents.OnKeyPress(args.VirtualKey);//האירוע שהגדרנו
            }
        }

        private void _runTimer_Tick(object sender, object e)
        {
            foreach(GameObject obj in _gameObjects)
            {
                if (obj is GameMovingObject moveObj)
                    moveObj.Render();
            }
            CheckCollisional();
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

        private void CheckCollisional()
        {
            for(int i = 0; i < _gameObjects.Count; i++)
            {
                for(int j = 0; j < _gameObjects.Count; j++)
                {
                    if(i!=j && _gameObjects[i].Collisional && _gameObjects[j].Collisional
                        && !RectHelper.Intersect(_gameObjects[i].Rect(), _gameObjects[j].Rect()).IsEmpty)
                    {
                        _gameObjects[i].Collide(_gameObjects[j]);
                    }
                }
            }
        }
    }
}

