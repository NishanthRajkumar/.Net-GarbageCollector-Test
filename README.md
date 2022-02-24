# .Net-GarbageCollector-Test
Testing the workings of .Net Garbage Collector using destructors and logger

_**Test Observation:**_
-   `GC.CollectionMode.Default` instantly forced the Garbage Collector to remove unreferenced object memories. `GC.CollectionMode.Default` is the same as `GC.CollectionMode.Forced`
-   `GC.CollectionMode.Optimised` gives the GC flexibility to behave according it's own logic. As per the log records, the GC decided to remove after 3 hours and 44 min approx.
