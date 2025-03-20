// See https://aka.ms/new-console-template for more information
using SecondTask.Classes;
using SecondTask.Decorators;
using SecondTask.Interfaces;

IDateTime dateTime = new AddPointDecorator(new American(2, 34, 4, 12, 2005));
dateTime.AddSymbols();
IDateTime dateTime1 = new AddDashDecorator(new Europian(2, 34, 4, 12, 2005));
dateTime1.AddSymbols();
