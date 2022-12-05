using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        
        //Environment.SetEnvironmentVariable("Env_Test2", "Env_Value2"); // sistemin ortamına set ediyoruz.
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddJsonFile("appSettings.json")
            .AddEnvironmentVariables()//sistemdeki environment dosyasının okunması için
            .Build();

        var dbName = configuration["DatabaseName"];
        var userName= configuration["UserName"];
        var envTest = configuration["Env_Test2"];
        Console.WriteLine($"Veritabanı Adı: {dbName}. Kullanıcı Adı: {userName}. Sistemdeki Environment:{envTest}");
    }
}