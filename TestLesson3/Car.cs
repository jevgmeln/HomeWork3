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
            Console.WriteLine($"Your speed is: {Speed}");
        }

        public void SakamBraukt()
        {
            Console.WriteLine($"Jusu atrums ir {Speed}");
        }

        public void PalielinaAtrumu()
        {
            Speed += 10;
            Console.WriteLine($"Palielina atrumu. Jusu atrums ir: {Speed}");
        }

        public void SamazinaAtrumu()
        {
            Speed -= 10;
            Console.WriteLine($"Atrums ir samazinats. Jusu atrums ir: {Speed}");
        }

        public void MasinaStop()
        {
            Speed = 0;
            Console.WriteLine($"Jusu atrums ir {Speed}. Masina apstajas");
        }

    }
}

