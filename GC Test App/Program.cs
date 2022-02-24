using GC_Test_App;
using NLog;

Logger logger = LogManager.GetCurrentClassLogger();
logger.Info("App Start | GC_CollectionMode = Optimized");
Console.Title = "GC Test App";
Console.WriteLine("==========Garbage Collector Test==========");

Thread appClose = new Thread(() => Test.CollectOnKeyPress());
Thread gcCheck = new Thread(() => Test.CheckMemoryStatus());

// Will Force GC.Collect on key press from use
appClose.Start();

Test.Start();

GC.Collect(2, GCCollectionMode.Optimized);

gcCheck.Start();

while (gcCheck.IsAlive) ;

logger.Info("App Close");

Thread.Sleep(1000);