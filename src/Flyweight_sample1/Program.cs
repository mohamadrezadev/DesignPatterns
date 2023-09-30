// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<SoldierFlyweight> soldiers = new List<SoldierFlyweight>();

//for (int i = 0; i < 10000; i++)
//{
//    var temp = new ConcreatSoldierFlyweight()
//    {
//        SoliderType = "Soldier",
//    };
//    temp.Render(10, 50, 10, i);
//    soldiers.Add(temp);
    
//}

SoldierFactory factory = new SoldierFactory();
for (int i = 0; i < 10000; i++)
{
    var temp = factory.GetSoldier("Soldier");
    temp.Render(10, 50, 10, i);

}
Console.ReadLine();