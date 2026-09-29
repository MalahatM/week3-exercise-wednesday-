// Temperature uppgift

Temperatur myTemp = new Temperatur();

Console.WriteLine("Write your room's temperature:");

myTemp.Temperature = double.Parse(Console.ReadLine()!);

Console.WriteLine(myTemp.CheckTemperature());