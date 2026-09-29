// Temperature uppgift

Temperatur myTemp = new Temperatur();

Console.WriteLine("Write your room's temperature:");

myTemp.Temperature = double.Parse(Console.ReadLine()!);

Console.WriteLine(myTemp.CheckTemperature());

// Car uppgift
Car myCar = new Car();
Console.WriteLine("Write your car's age:");
myCar.Age = double.Parse(Console.ReadLine()!);
Console.WriteLine("Does your car have insurance? (true/false):");
myCar.Insurance = bool.Parse(Console.ReadLine()!);
Console.WriteLine(myCar.CheckAge());
  