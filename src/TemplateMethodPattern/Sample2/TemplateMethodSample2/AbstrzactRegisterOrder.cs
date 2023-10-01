public abstract class AbstrzactRegisterOrder
{
    public void Excute()
    {
        RegisterOrder();
        SaveinDatabaae();
        changestock();
        SendNotification();

    }
    protected virtual void RegisterOrder()
    {
        Console.WriteLine("Order Registered .....");
    }

    protected virtual void SaveinDatabaae()
    {
        Console.WriteLine("Save data in database");
    }

    protected void changestock()
    {
        Console.WriteLine("change in the warehouse data in sqlserver..");
    }

    public abstract void SendNotification();
}