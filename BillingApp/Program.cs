using BillingApp.Data;
using BillingApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using BillingApp.Models;
using Microsoft.EntityFrameworkCore;


namespace BillingApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<AppDbContext>();
                context.Database.Migrate();

                // Create admin user if it doesn't exist
                CreateAdminUserIfNotExists(context);

                var loginForm = new LoginForm(context);
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    var mainForm = services.GetRequiredService<MainForm>();
                    Application.Run(mainForm);
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<AppDbContext>();
                    services.AddTransient<CustomerService>();
                    services.AddTransient<AddCustomerForm>();
                    services.AddTransient<MainForm>();
                });

        private static void CreateAdminUserIfNotExists(AppDbContext context)
        {
            var adminUser = context.Users.FirstOrDefault(u => u.Username == "admin");
            if (adminUser == null)
            {
                var passwordHash = BCrypt.Net.BCrypt.HashPassword("password");
                adminUser = new User
                {
                    Username = "admin",
                    PasswordHash = passwordHash,
                    Role = Role.Admin
                };
                context.Users.Add(adminUser);
                context.SaveChanges();
            }
        }
    }
}