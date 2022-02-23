namespace GC_Test_App;

internal class Test
{
    public static void Start()
    {
        new ClassB();
        for (int i = 0; i < 2; i++)
            new ClassA();
    }

    /*public static void Status()
    {
        G
    }*/
}
