static class Async4
{

    async static Task Main(string[] args)
    {
        // If you have multiple async methods that return the values then you can use await for all methods just before you want to use the return value in further steps.
        // Example: Async Methods
        Task<int> result1 = Async4.LongProcess1();
        Task<int> result2 = Async4.LongProcess2();
        Console.WriteLine("After two long processes.");
        int val2 = await result1; // wait until we get the return value
        Async4.DisplayResult(val2);

        val2 = await result2; // wait until we get the return value
        Async4.DisplayResult(val2);
    }
    static async Task<int> LongProcess1()
    {
        Console.WriteLine("LongProcess 1 Started");

        await Task.Delay(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess 1 Completed");

        return 10;
    }

    static async Task<int> LongProcess2()
    {
        Console.WriteLine("LongProcess 2 Started");

        await Task.Delay(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess 2 Completed");

        return 20;
    }

    static void DisplayResult(int val)
    {
        Console.WriteLine(val);
    }
}