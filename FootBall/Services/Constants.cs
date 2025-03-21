using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall.Services
{
    public static class Constants
    {
        public static Level Level { get; set; } = new Level();

        public static readonly double  Speed = 10;
        public static readonly double  AccelerationBall =0.4;
        public static readonly double KickStrength = 1.5;
        public static readonly int totalTime = 60;
        public static readonly double ballSpeedMultiplier = Level.ballSpeed;
        
    }
}
