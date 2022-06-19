using System;
namespace TestLesson3
{
	public class Phone
	{
		public string Brand { get; set; }

		public string Model { get; set; }

		public double Size { get; set; }

        public void PhoneCharacteristics()
        {
            Console.WriteLine($"Telefona marka: {Brand}");
            Console.WriteLine($"Telefona modelis: {Model}");
            Console.WriteLine($"Telefona izmeri: {Size}");
        }


        public void Calling()
        {
            Console.WriteLine("Calling");
        }

        public void SendSms()
        {
            Console.WriteLine("SMS was sent");
        }
    }
}

