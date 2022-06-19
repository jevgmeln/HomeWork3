// See https://aka.ms/new-console-template for more information


using TestLesson3;

Person person = new Person("Eugene");

//person.Name = "Eugene";
person.Age = 33;
person.IsMale = true;

person.Greeting();


Person Anna = new Person();
Anna.Name = "Anna";
Anna.Age = 17;
Anna.IsMale = false;
 

Anna.Greeting();

bool isAnnaAdult = Anna.IsAdult;
bool IsAnnaAdult2 = Anna.GetIsAdult();

Console.WriteLine(isAnnaAdult);
Console.WriteLine(IsAnnaAdult2);



//Uzdevums TELEFONS
Console.WriteLine("Uzdevums Telefons");

Phone iPhone12 = new();

iPhone12.Brand = "Apple";
iPhone12.Model = "Iphone 12 Pro Max";
iPhone12.Size = 25.55;

iPhone12.PhoneCharacteristics();


iPhone12.Calling();
iPhone12.SendSms();


//Uzdevums MASINA
Console.WriteLine("Uzdevums Masina");

Person personWithCar = new Person();
personWithCar.Name = "Armands";

personWithCar.Car = new Car();
personWithCar.Car.Model = "Tesla";
personWithCar.Car.CarNumber = "LL-3567";

personWithCar.Car.BeepBeep();

 


