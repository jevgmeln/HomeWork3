using System;
namespace TestLesson3
{
	public class Person
	{

		public Person(string name)
        {
			Name = name;
        }

		public Person()
        {

        }

		public string? Name { get; set; }

		public int Age { get; set; }

		public bool IsMale { get; set; }

		public bool IsAdult
		{
			get
            {
				return Age >= 18;
            }
		}

		public Car Car { get; set; }

		public void Greeting()
        {
			Console.WriteLine($"Hello, My name is: {Name} \n and I am {Age} And I am a man {IsMale}");
        }

		public bool GetIsAdult()
        {
			return Age >= 18;
        }
	}
}

