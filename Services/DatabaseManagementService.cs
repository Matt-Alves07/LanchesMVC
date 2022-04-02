using LanchesMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMVC.Services
{
    public class DatabaseManagementService
    {
        public static void MigrationInitialisation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                serviceScope.ServiceProvider.GetService<AppDBContext>().Database.Migrate();
            }
        }
    }
}
