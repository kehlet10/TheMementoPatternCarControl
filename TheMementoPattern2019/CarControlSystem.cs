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
        private SpeedRegulator.RegulatorState regulatorState;
        private ISpeedRegulator regulator;

        CarControlSystem(ISpeedRegulator _regulator, float _currentSpeed)
        {
            currentSpeed = _currentSpeed;
            regulator = _regulator;
        }

        void startAutopilot()
        {
            Console.WriteLine("Starting autopilot...\n");
            regulator.setSpeed(currentSpeed);
        }

        void stopAutopilot()
        {
            Console.WriteLine("Stopping autopilot...\n");
        }

        void carDetected()
        {
            Console.WriteLine("CarDetected...\n");
            stopAutopilot();
            regulator.saveSpeed();
        }

        void roadClear()
        {
            Console.WriteLine("Road is clear. Restoring speed...\n");
            regulator.restoreSpeed(regulatorState);
        }
    }
}
