namespace TebeeLite.WinForms;
using Microsoft.Extensions.DependencyInjection;
using TebeeLite.Infrastructure;      // ·‰› —÷ √‰ DbContext Ê Repos Â‰«
using TebeeLite.Application; // Œœ„«  „‰ ÿ»ﬁ… Application
using TebeeLite.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using TebeeLite.Infrastructure.Models;
using TebeeLite.Application.Interfaces.Repositories;
using TebeeLite.Infrastructure.Repositories;
using TebeeLite.Application.Interfaces.Services;
using TebeeLite.Application.Services;
using TebeeLite.WinForms.User;
using System.Configuration;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // 1. ≈‰‘«¡ ServiceCollection
        var services = new ServiceCollection();

        // 2.  ”ÃÌ· «·Œœ„«  (DbContext, Repositories, Services, Forms)
        ConfigureServices(services);

        // 3. »‰«¡ ServiceProvider
        var serviceProvider = services.BuildServiceProvider();

        // 4. «” œ⁄«¡ «·›Ê—„ «·—∆Ì”Ì ⁄»— DI
        var loginForm = serviceProvider.GetRequiredService<LoginForm>();
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
       
        System.Windows.Forms.Application.Run(loginForm);

    }
    private static void ConfigureServices(ServiceCollection services)
    {
        //  ”ÃÌ· DbContext - ⁄œ· «·‹ connection string Õ”» »Ì∆ ﬂ
        services.AddDbContext<TebeeLiteDbContext>(options =>
            options.UseSqlServer("Server=.;Database=TebeeLiteDB;User Id=sa;Password=123456;Trusted_Connection=true;TrustServerCertificate=True;"));

       /* services.AddDbContextFactory<TebeeLiteDbContext>(options =>
    options.UseSqlServer("Server=.;Database=TebeeLiteDB;User Id=sa;Password=123456;Trusted_Connection=true;TrustServerCertificate=True;"));
       */
        //  ”ÃÌ· «·—Ì»Ê Ê«·Œœ„«  („À«·)
        services.AddScoped<IDoctorRepository, DoctorRepository>();
         services.AddScoped<IDoctorService, DoctorService>();

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();

        services.AddScoped<IAuthService, AuthService>();

        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IRoleService, RoleService>();

        //  ”ÃÌ· «·›Ê—„«  (Forms)
        services.AddTransient<ManageUsersForm>();
        services.AddTransient<AddUserForm>();
        services.AddTransient<EditUserForm>();
        services.AddTransient<LoginForm>();
        services.AddTransient<MainForm>();
        // ≈–« ⁄‰œﬂ Forms √Œ—Ï ”Ã·Â« Â‰«
    }
}