public abstract class SoldierFlyweight
{
    public string SoliderType { get; set; }
    public abstract void Render(int x, int y, int z, int number);

    public void SetSoliderType(string type)
    {
        this.SoliderType=type;
    }
}
public class ConcreatSoldierFlyweight : SoldierFlyweight
{
    public override void Render(int x, int y, int z, int number)
    {
        Console.WriteLine($"Soldier type --->{SoliderType} show location Soldier" +
            $" --->x:{x}, y:{y},z:{z} ---->Number :{number}");
    }

}
public class SoldierFactory
{
    private static Dictionary<string, SoldierFlyweight> Flyweights = new Dictionary<string, SoldierFlyweight>();
    
    public SoldierFlyweight GetSoldier(string soldierType)
    {
        SoldierFlyweight soldierFlyweight= null;
        if (Flyweights.TryGetValue(soldierType, out soldierFlyweight)) { }
        else{
            SoldierFlyweight ConcreFlyweight = new ConcreatSoldierFlyweight();
            ConcreFlyweight.SetSoliderType(soldierType);
            Flyweights.Add(soldierType, ConcreFlyweight);

        }
        return Flyweights[soldierType];
    }
}
