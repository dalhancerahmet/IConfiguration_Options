using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(),"Files");
        IConfiguration configuration = new ConfigurationBuilder()
            .AddKeyPerFile(directoryPath:path,true)
            .Build();

        var dbName = configuration["DatabaseName"];
        Console.WriteLine(dbName);
    }
}