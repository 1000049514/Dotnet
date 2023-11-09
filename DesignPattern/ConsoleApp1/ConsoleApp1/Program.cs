// See https://aka.ms/new-console-template for more information
using Singleton;
using AbstractFactory;

// Console.WriteLine("Hello, Below is the Singleton Pattern!!");

// Singleton.Singleton x = Singleton.Singleton.GetSingleton();
// x.PrintInstances();
// Singleton.Singleton y = Singleton.Singleton.GetSingleton();
// y.PrintInstances();

Console.WriteLine("Hello, Below is the Abstractt Pattern!!");

AutomobileFactory automobileFactory = new AutomobileFactory();
Console.WriteLine(automobileFactory.CreateSedanCar().name);
Console.WriteLine(automobileFactory.CreateSportCar().name);
