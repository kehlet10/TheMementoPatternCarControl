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
        private IRegulatorState regulatorState;
        private ISpeedRegulator regulator;

        public CarControlSystem(ISpeedRegulator _regulator, float _currentSpeed)
        {
            currentSpeed = _currentSpeed;
            regulator = _regulator;
        }

        public void startAutopilot()
        {
            Console.WriteLine("Starting autopilot...\n");
            regulator.setSpeed(currentSpeed);
        }

        public void stopAutopilot()
        {
            Console.WriteLine("Stopping autopilot...\n");
        }

        public void carDetected()
        {
            Console.WriteLine("CarDetected...\n");
            regulatorState = regulator.saveSpeed();
        }

        public void roadClear()
        {
            Console.WriteLine("Road is clear. Restoring speed...\n");
            regulator.restoreSpeed(regulatorState);
        }
    }
}
