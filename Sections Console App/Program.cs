using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        IConfigurationRoot configuration= new ConfigurationBuilder()
            .AddJsonFile("appSettings.json")
            .Build();

        var databaseName = configuration["Database:Name"];
        Console.WriteLine(databaseName);
    }
}