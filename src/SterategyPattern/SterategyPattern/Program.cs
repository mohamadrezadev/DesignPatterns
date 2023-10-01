// See https://aka.ms/new-console-template for more information


Context context;
    context=new (new ConcreateSterategyA());
context.ContextInterface();

context = new(new ConcreateSterategyB());
context.ContextInterface();

 context = new(new ConcreateSterategyC());
context.ContextInterface();