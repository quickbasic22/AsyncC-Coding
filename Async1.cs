public static class Async1
{
    public static void Main(string[] args)
    {
        // Example: Asynchronous Program
        Async1.LongProcess();
        Async1.ShortProcess();

    }

    public static void LongProcess()
    {
        Console.WriteLine("LongProcess Started");

        //some code that takes long execution time 
        System.Threading.Thread.Sleep(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess Completed");
    }

    public static void ShortProcess()
    {
        Console.WriteLine("ShortProcess Started");

        //do something here

        Console.WriteLine("ShortProcess Completed");
    }

}
