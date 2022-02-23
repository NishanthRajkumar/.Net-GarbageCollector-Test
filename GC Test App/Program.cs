using GC_Test_App;
using NLog;

Logger logger = LogManager.GetCurrentClassLogger();
logger.Info("App Start | GC_CollectionMode = Optimized");
Console.Title = "GC Test App";
Console.WriteLine("==========Garbage Collector Test==========");

Test.Start();

GC.Collect(2, GCCollectionMode.Default);

// Wait untill all destructor for all the object memory is called
while (ClassA.count > 0 || ClassB.count > 0) ;

logger.Info("App Close");

Console.WriteLine("Program completed! check 'GC log.txt' file");
Console.ReadKey();