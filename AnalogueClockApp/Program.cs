using System;

namespace AnalogueClockApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hours;
            int Minutes;
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("The program will calculate the smaller angle of the analog \n" +
                "clock in degrees between the hour arrow and the minute arrow.");
                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine("Please enter the hours (0 - 23): ");
                    if (!int.TryParse(Console.ReadLine(), out Hours))
                    {
                        Console.WriteLine("Bad input!");
                    }
                    else if (Hours >= 0 && Hours < 24)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number of hours is exceeded!");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Please enter the minutes (0 - 59): ");
                    if (!int.TryParse(Console.ReadLine(), out Minutes))
                    {
                        Console.WriteLine("Bad input!");
                    }
                    else if (Minutes >= 0 && Minutes < 60)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number of minute is exceeded!");
                    }
                }
                Console.WriteLine($"The hours entered are: {Hours}:{Minutes}");

                ClockApp app = new ClockApp(Hours, Minutes);

                app.FindAngle();

                Console.WriteLine("If you want to repeat, press: y");

                loop = Console.ReadLine() == "y";

            }



        }
    }
}
