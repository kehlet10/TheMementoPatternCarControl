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
        private ISpeedRegulator regulator;

        CarControlSystem(ISpeedRegulator _regulator)
        {
            currentSpeed = regulatorState.getSpeed();
            regulator = _regulator;
        }

        void startAutopilot()
        {
            Console.WriteLine("Starting autopilot...");
            regulator.setSpeed(currentSpeed);
        }

        void stopAutopilot()
        {
            Console.WriteLine("Stopping autopilot...");
            regulatorState
        }

        void carDetected()
        {
            Console.WriteLine("CarDetected");
        }

        void roadClear()
        {
            Console.WriteLine("Road is clear. Restoring                                                                                                                                                                                                                                                                             ")
        }
    }
}
