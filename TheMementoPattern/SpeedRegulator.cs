using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMementoPattern
{
    public class SpeedRegulator
    {
        private float speed;

        public SpeedRegulator()
        {
            speed = new float(0.0f);
        }



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
