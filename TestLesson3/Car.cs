using System;
namespace TestLesson3
{
	public class Car
	{
        public string? Model { get; set; }

        public string? CarNumber { get; set; }

        public double Speed { get; set; }

        public void BeepBeep()
        {
            Console.WriteLine($"{Model} Beep Beep");
        }

    }
}

