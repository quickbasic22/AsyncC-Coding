static class Async3
{

    static async Task Main(string[] args)
    {
        // The following demonstrates the async method that returns a value. 
        // Example: Async Method Returns Value

        Task<int> result = Async3.LongProcess();
        Async3.ShortProcess();
        var val = await result; //wait until we get the return value
        Console.WriteLine("Result: {0}", val);

    }
    static async Task<int> LongProcess()
    {
        Console.WriteLine("LongProcess Started");

        await Task.Delay(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess Completed");

        return 10;
    }

    static void ShortProcess()
    {
        Console.WriteLine("ShortProcess Started");

        //do something here

        Console.WriteLine("ShortProcess Completed");
    }
}