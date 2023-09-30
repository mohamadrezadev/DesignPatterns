using BuilderPattern.classes;

public abstract class Builder<T>
{
    protected T buildeobj;
    public Builder()
    {
        buildeobj=default(T);
    }


    public abstract void BuildPart1();
    public abstract void BuildPart2();

    public virtual T Getresult()
    {
        return buildeobj;
    }
}

public class Director<T>
{
    private Builder<T> builder;
    public void SetBuilder(Builder<T> builder)
    {
        this.builder= builder;
    }

    public void Construct()
    {
        builder.BuildPart1();
        builder.BuildPart2();
    }

}