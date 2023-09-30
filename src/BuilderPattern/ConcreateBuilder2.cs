using BuilderPattern.classes;

public class ConcreateBuilder2 : Builder<Product>
{
    public ConcreateBuilder2()
    {
        this.buildeobj = new();
    }
    public override void BuildPart1()
    {
        buildeobj.Part1 = "x Part1";
    }

    public override void BuildPart2()
    {
        buildeobj.Part2 = "x Part2";
    }

    public override Product Getresult()
    {
        buildeobj.Name = "Product 2 from Builder2";
        Console.WriteLine($"{buildeobj.Name} Created");
        return base.Getresult();
    }
}