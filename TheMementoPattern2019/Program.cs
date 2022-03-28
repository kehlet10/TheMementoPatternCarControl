using System;

namespace TheMementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISpeedRegulator regulator = new SpeedRegulator();
            CarControlSystem system = new CarControlSystem(regulator, 140.0f);
            ConsoleKeyInfo action;

            Console.WriteLine("Choose action:\ns: Start autopilot\nq: Stop autopilot\n+: Increase speed\n-: Decrease speed\n!: Car detected\n0: Road clear\nx: End program");

            do
            {
                action = Console.ReadKey();
                Console.WriteLine(": ");

                switch(action.KeyChar)
                {
                    case '+':
                        regulator.increaseSpeed();
                        break;
                    case '-':
                        regulator.decreaseSpeed();
                        break;
                    case '!':
                        system.carDetected();
                        break;
                    case '0':
                        system.roadClear();
                        break;
                    case 's':
                        system.startAutopilot();
                        break;
                    case 'q':
                        system.stopAutopilot();
                        break;

                    default:
                        break;
                }
            } while (action.KeyChar != 'x');
        }
    }
}
