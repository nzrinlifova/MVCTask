using Microsoft.EntityFrameworkCore;
using MVCTask.Context;

namespace MVCTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            string connectionStr = "server=DESKTOP-R3G5OPM\\SQLEXPRESS;Database=ClinicAppDb;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=true";//serverim yoxdur, basqa serverle de islemedi. Migrations u sildim ona gore

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionStr));

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();
        }
    }
}


