// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
ConcreatPortotype1 service1=new ConcreatPortotype1(1569,"test");
var service2=(ConcreatPortotype1)service1.Clone();
Console.WriteLine((service1.Property1));
Console.WriteLine((service2.Property2));
Console.WriteLine(service1==service2);

Console.WriteLine("----------------------------------");
ConcreatPortotype2 servicecomplex1= new ConcreatPortotype2(service1);

var servicecomplex2=(ConcreatPortotype2)servicecomplex1.Clone();
Console.WriteLine(servicecomplex1.myapp1.Property2);
Console.WriteLine(servicecomplex2.myapp1.Property1);
Console.WriteLine(servicecomplex1==servicecomplex2);