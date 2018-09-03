using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var isStarted = false;
            var watch = new Watch();

            while (!isStarted)
            {
                var validInput = false;
                while (!validInput)
                {
                    Console.WriteLine("Please enter START to start the clock...");
                    if (Console.ReadLine().ToUpper() == "START")
                    {
                        watch.start();
                        isStarted = true;
                        validInput = true;
                    }
                }

                validInput = false;
                while (!validInput)
                {
                    Console.WriteLine("Please enter STOP anytime to stop the clock...");
                    if (Console.ReadLine().ToUpper() == "STOP")
                    {
                        watch.stop();
                        isStarted = false;
                        validInput = true;
                    }
                }
            }
        }
    }
}
