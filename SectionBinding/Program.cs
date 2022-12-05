using Microsoft.Extensions.Configuration;
using SectionBinding;

internal class Program
{
    private static void Main(string[] args)
    {
       IConfigurationRoot configuration= new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        var optionModel = new DatabaseOptionModel();
        configuration.GetSection("Database").Bind(optionModel);
        Console.WriteLine(optionModel.UserName);
        Console.WriteLine(optionModel.Password);
    }
}