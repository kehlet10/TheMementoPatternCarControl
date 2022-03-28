using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMementoPattern
{
    public class SpeedRegulator: ISpeedRegulator
    {
        private float speed;

        public SpeedRegulator()
        {
            speed = new float(0.0f);
        }

        public void setSpeed(float _speed)
        {
            Console.WriteLine($"Regulator started with speed: {speed} km/h");
            speed = _speed;
        }

        public void stopRegulator()
        {
            Console.WriteLine("Regulator stopped");
        }
        public void increaseSpeed()
        {
            Console.WriteLine($"Speed was increased from {speed} km/h to {speed + 10.0f} km/h");
            speed += 10.0f;
        }
        public void decreaseSpeed()
        {
            if (speed < 10.0f) return;

            Console.WriteLine($"Speed was decreased from {speed} km/h to {speed - 10.0f} km/h");
            speed -= 10.0f;
        }
        public SpeedRegulator.RegulatorState saveSpeed()
        {
            return new RegulatorState(speed);
        }

        public void restoreSpeed(SpeedRegulator.RegulatorState regulatorState)
        {
            speed = regulatorState.getSpeed();
        }


        public class RegulatorState
        {
            private float speed;
            public RegulatorState(float _speed)
            {
                speed = _speed;
            }

            internal float getSpeed()
            {
                return speed;
            }

        }
    }
}
