using System;

namespace VirtualPets
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to the Astromech android diagnostic program");
            Console.WriteLine("This program will help diagnose your Astromech android, press any key to start diagnostics.");
            Console.ReadLine();
            Console.WriteLine("Please enter the model from the menu below that correlates with the type of Astromech android.");

            Console.WriteLine("R2");
            Console.WriteLine("CP");
            Console.WriteLine("BB");
            Console.WriteLine("Type END to exit program");
            string userDroidType = Console.ReadLine().ToUpper();

            if (userDroidType == "R2")
            {
                Console.WriteLine("We are working on a R2D2 unit");
            }
            else if (userDroidType == "CP")
            {
                Console.WriteLine("We are working on a CP-3O unit");
            }
            else if (userDroidType == "BB")
            {
                Console.WriteLine("We are working on a BB8 unit");
            }
            else if (userDroidType == "END")
            {
                Console.WriteLine("Thank you for using the Astromech program");
                return;
            }

            VirtualPets droid = new VirtualPets(userDroidType);
            do
            {
                {
                    Console.WriteLine("The {0} Diagnostic status:", userDroidType);
                    Console.WriteLine("\n {0}% Battery level", droid.BatteryLevel);
                    Console.WriteLine("\n {0}% Hydraulic pressure", droid.HydrolicPressure);
                    Console.WriteLine("\n {0}% Tune up", droid.TuneUp);
                    Console.WriteLine();

                    Console.WriteLine("Please enter an option to fix the android.");
                    Console.WriteLine("\nPress 1 to fix battery level on the  {0}", userDroidType);
                    Console.WriteLine("\nPress 2 to fix Hydraulic Level on the {0}", userDroidType);
                    Console.WriteLine("\nPress 3 to tune up your {0}", userDroidType);
                    Console.WriteLine("\nPress 4 to exit program");
                    int userChoice = Int32.Parse(Console.ReadLine());

                    switch (userChoice)
                    {
                        case 1:
                            droid.FixBattery();
                            droid.BatteryFixed = true;
                            break;

                        case 2:
                            droid.FixHydraulicPressure();
                            droid.HydraulicPressureFixed = true;
                            break;

                        case 3:
                            droid.FixTuneUp();
                            droid.IsTunedUp = true;
                            break;

                        case 4:
                            userDroidType = "END";
                            Console.WriteLine("Thank you for using the Astromech program");
                            break;

                        default:
                            break;
                    }

                    droid.Tick();
                }
            } while (userDroidType != "END");
        }
    }
}