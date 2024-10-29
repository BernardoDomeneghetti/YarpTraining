internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddReverseProxy()


        var app = builder.Build();
        app.Run();
    }
}