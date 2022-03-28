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
            speed = new float();
            speed = 0.0f;
        }

        public void setSpeed(float _speed)
        {
            speed = _speed;
            Console.WriteLine($"Regulator started with speed: {speed} km/h");
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
        public IRegulatorState saveSpeed()
        {
            Console.WriteLine($"Speed: {speed} km/h has been saved in memento");
            return new RegulatorState(speed);
        }

        public void restoreSpeed(IRegulatorState regulatorState)
        {
            speed = ((RegulatorState)regulatorState).getSpeed();
            Console.WriteLine($"Regulator restored to previous speed: {speed} km/h");
        }

    }
}
