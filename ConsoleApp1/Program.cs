// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using static Tests.Utility;

var mazda  = new Car("Mazda",  distance: 10, hours: 1);
var toyota = new Car("Toyota", distance: 35, hours: 2);

var cars = new List<Car>() { mazda, toyota };

Console.WriteLine($"Report:\n{Report(cars)}");