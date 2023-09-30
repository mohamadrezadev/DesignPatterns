// See https://aka.ms/new-console-template for more information

using BuilderPattern.classes;


Director<Product> director=new ();

var builder1=new ConcreateBuilder1();
var builder2=new ConcreateBuilder2();

director.SetBuilder(builder1);
director.Construct();
var Product1 = builder1.Getresult();
Product1.DisplayInfo();


director.SetBuilder(builder2);
director.Construct();
var Product2 = builder2.Getresult();
Product2.DisplayInfo();

Console.WriteLine("................");

