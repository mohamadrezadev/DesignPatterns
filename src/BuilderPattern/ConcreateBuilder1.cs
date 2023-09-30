using BuilderPattern.classes;

public class ConcreateBuilder1 : Builder<Product>
{
    public ConcreateBuilder1()
    {
        this.buildeobj = new();
    }
    public override void BuildPart1()
    {
        buildeobj.Part1 = "Part1";
    }

    public override void BuildPart2()
    {
        buildeobj.Part2 = "Part2";
    }

    public override Product Getresult()
    {
        buildeobj.Name = "Product 1";
        Console.WriteLine($"{buildeobj.Name} Created");
        return base.Getresult();
    }
}