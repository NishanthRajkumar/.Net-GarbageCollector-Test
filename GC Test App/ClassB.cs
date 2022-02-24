using NLog;

namespace GC_Test_App;

public class ClassB
{
    // Static attributes
    public static int count;
    private static readonly Logger logger;

    // Non static attributes
    public readonly int id;
    private ClassA objectA;

    // Static Constructor
    static ClassB()
    {
        count = 0;
        logger = LogManager.GetCurrentClassLogger();
        logger.Info("Static constructor invoked");
        Console.WriteLine("CLassB static constructor invoked");
    }

    // Default Constructor
    public ClassB()
    {
        id = ++count;
        logger.Info($"Default constructor invoked for Object id: {id}");
        Console.WriteLine($"ClassB default constructor invoked for Object id: {id}");
        objectA = new ClassA();
    }

    // Destructor
    ~ClassB()
    {
        count = 0;
        logger.Info($"Destructor invoked for Object id: {id}");
        Console.WriteLine($"ClassB destructor invoked for Object id: {id}");
    }
}
