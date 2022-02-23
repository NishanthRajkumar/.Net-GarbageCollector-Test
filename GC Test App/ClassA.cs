using NLog;

namespace GC_Test_App;

public class ClassA
{
    // Static attributes
    public static int count;
    private static readonly Logger logger;

    // Non static attributes
    public readonly int id;

    // Static Constructor
    static ClassA()
    {
        count = 0;
        logger = LogManager.GetCurrentClassLogger();
        logger.Info("Static constructor invoked");
        Console.WriteLine("ClassA static constructor invoked");
    }

    // Default Constructor
    public ClassA()
    {
        id = ++count;
        logger.Info($"Default constructor invoked by Object id: {id}");
        Console.WriteLine($"ClassA default constructor invoked by Object id: {id}");
    }

    // Destructor
    ~ClassA()
    {
        count = 0;
        logger.Info($"Destructor invoked for Object id: {id}");
        Console.WriteLine($"ClassA destructor invoked for Object id: {id}");
    }
}
