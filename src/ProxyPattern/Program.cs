namespace ProxyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Proxy();
            subject.DoAction();
            Console.WriteLine("Hello, World!");
        }
    }
    public interface ISubject
    {
        void DoAction();
     
    }
    internal  class RealeSubject : ISubject
    {
        public void DoAction()
        {
            Console.WriteLine($"run RealeSubject method DoAction is run");
        }
    }
    public class Proxy:ISubject
    {
        private  RealeSubject _RealeSubject;
        public void DoAction()
        {
      
            GetRealesubject().DoAction();
            _RealeSubject.DoAction();
        }
       
        private RealeSubject GetRealesubject()
        {
            if (_RealeSubject == null)
            {
                _RealeSubject = new RealeSubject();

            }
            return _RealeSubject;
        }
    }
}
