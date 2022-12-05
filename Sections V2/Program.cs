using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        IConfigurationRoot configuration= new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        var dbSections = configuration.GetSection("Database");
        var databaseName = dbSections["UserName"];
        var databasePassword= dbSections["Password"];
        Console.WriteLine($"{databaseName} {databasePassword}");
    }
}