static class Async2
{
    static void Main(string[] args)
    {
        // Now let's rewrite the above example in asynchronous pattern using async keyword.

        Async2.LongProcess();
        Async2.ShortProcess();
    }
    static async void LongProcess()
    {
        Console.WriteLine("LongProcess Started");

        await Task.Delay(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess Completed");

    }

    static void ShortProcess()
    {
        Console.WriteLine("ShortProcess Started");

        //do something here

        Console.WriteLine("ShortProcess Completed");
    }
}