
using System.ComponentModel.Design;


FlyweighitFactory Factory=new FlyweighitFactory();

var obj1= Factory.GetFlyweighit("test1");
var obj2=Factory.GetFlyweighit("test2");
var obj3=Factory.GetFlyweighit("test1");

obj1.Operation("sample1 extra State ");
obj2.Operation("sample2 extra State ");
obj3.Operation("sample3 extra State ");

UnSharedConcreatflyweighit flyweighits = new UnSharedConcreatflyweighit(
    new flyweighit[]
    {
        Factory.GetFlyweighit("test1"),
        Factory.GetFlyweighit("test2"),
        Factory.GetFlyweighit("test3"),
        Factory.GetFlyweighit("test4"),
    });
flyweighits.Operation($"extra states ------------------->{nameof(UnSharedConcreatflyweighit)}");
Console.ReadLine();
