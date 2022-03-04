namespace AwaitUsing_BugReport_VS2022;

public class NonsenseException : Exception { }

public class Main
{
    public async Task<dynamic> StartAsync()
    {
        await using var stream = new MemoryStream();

        try
        {
            return new
            {
                FileName = "FileName",
                FileContent = stream.ToArray()
            };
        }
        catch (NonsenseException nonsenseException)
        {
            Console.WriteLine("Not outputted");
            throw new Exception("line 22");
        }
        catch (Exception exception)
        {
            Console.WriteLine("Not outputted");
            throw new Exception("line 27");
        }
    }
}