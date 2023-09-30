// See https://aka.ms/new-console-template for more information

var obj1 =Singleton.GetInstance();
var obj2 =Singleton.GetInstance();
Console.WriteLine(obj1==obj2);