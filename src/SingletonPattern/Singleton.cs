public class Singleton
{
   // private static  Singleton uniqInstance ;
    private readonly Lazy<Singleton> uniqsingleton =new Lazy<Singleton>() ;
    private Singleton()
    {
        
    }

    public   Singleton GetInstance()
    {
        //    if (uniqInstance==null)
        //    {
        //        uniqInstance = new Singleton();
        //    }
        

        return uniqsingleton.Value;
    }
}  