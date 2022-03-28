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

        public void setSpeed(float speed)
        {
            Console.Writeline("");
        }

        public void stopRegulator();
        public void increaseSpeed();
        public void decreaseSpeed();
        public SpeedRegulator.RegulatorState saveSpeed();

        public void restoreSpeed(SpeedRegulator.RegulatorState regulatorState);


        public class RegulatorState
        {
            private float speed;
            public RegulatorState(float _speed)
            {
                speed = _speed;
            }

            private float getSpeed()
            {
                return speed;
            }

        }
    }
}
