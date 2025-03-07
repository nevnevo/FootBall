using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace FootBall.Services
{
    public class GameEvents
    {
        public Action<VirtualKey> OnKeyPress;
        public Action<VirtualKey> OnKeyLeave;
        public Action OnMousePress;
        public Action<int, int> onUpdateScore;

    }
}
