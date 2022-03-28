using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMementoPattern
{
    public class CarControlSystem
    {
        private float currentSpeed;
        private RegulatorState regulatorState;

        CarControlSystem()
        {
            currentSpeed = regulatorState.getSpeed();
        }

        void startAutopilot()
        {
            return regulatorState;
        }

        void stopAutopilot()
        {

        }

        void carDetected()
        {

        }

        void roadClear()
        {

        }
    }
}
