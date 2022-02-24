namespace GC_Test_App;

internal class Test
{
    // Starts the test of creating unreferenced objects to test GC
    public static void Start()
    {
        new ClassB();
        for (int i = 0; i < 2; i++)
            new ClassA();
    }

    // Waits for ReadKey from user to force GC to collect
    public static void CollectOnKeyPress()
    {
        Console.ReadKey();
        GC.Collect(2, GCCollectionMode.Forced);
    }

    // Checks if all object memories are removed by GC 
    public static void CheckMemoryStatus()
    {
        while (ClassA.count > 0 || ClassB.count > 0) ;
        Console.WriteLine("GC completed! check 'GC log.txt' file");

    }
}
