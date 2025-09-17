namespace MVCCC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/login",  signin);

            app.MapControllerRoute(
                name: "default",
              pattern: "{controller}/{action}"
                );
            app.UseStaticFiles();
            app.Run();
        }
    }
}
