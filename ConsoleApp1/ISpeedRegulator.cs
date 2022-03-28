using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMementoPattern
{
    public interface ISpeedRegulator
    {
        public void setSpeed(float speed);

        public void stopRegulator();
        public void increaseSpeed();
        public void decreaseSpeed();
        public SpeedRegulator.RegulatorState saveSpeed();

        public void restoreSpeed(SpeedRegulator.RegulatorState regulatorState);
    }
}
