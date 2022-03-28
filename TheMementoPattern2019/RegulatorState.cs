using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMementoPattern2019
{
    public class RegulatorState: IRegulatorState
    {
        private float speed;
        public RegulatorState(float _speed)
        {
            speed = _speed;
        }

        public float getSpeed()
        {
            return speed;
        }

    }
}
