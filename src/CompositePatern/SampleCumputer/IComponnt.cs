namespace CompositePatern.SampleCumputer
{
    public interface IComponnt
    {
        string Name { get; set; }
        int price { get; set; }
        int DesplayPrice();

    }
    public class Leaf : IComponnt
    {
        public string Name { get; set; }
        public int price { get; set; }

        public Leaf(string name, int price)
        {
            Name = name;
            this.price = price;
        }  


        public int DesplayPrice()
        {
           Console.WriteLine(Name+':'+price);
            return price;
        }
    }
    public class Composite : IComponnt
    {
        public string Name { get ; set; }
        public int price { get; set ; }
        List<IComponnt> components { get; set; }=new List<IComponnt>();
        public Composite(string name,int price)
        {
            this.Name = name;
            this.price = price;
        }
        public void Add(IComponnt componnt )
        {
            components.Add(componnt);
        }
        public int DesplayPrice()
        {
            int sumprice = price;
            foreach (var item in components)
            {
               sumprice+= item.DesplayPrice();
            }
            Console.WriteLine(Name + ':' + sumprice);
            return sumprice;
        }
    }
}
