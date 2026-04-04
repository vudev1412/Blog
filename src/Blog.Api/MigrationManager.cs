using Blog.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Blog.Api
{
    public static class MigrationManager
    {
        public static async Task<WebApplication> MigrateDatabase(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope()) { 
                using (var context = scope.ServiceProvider.GetRequiredService<BlogContext>())
                {
                    context.Database.Migrate();
                    new DataSeeder().SeedAsync(context).Wait();
                }
            }
            return app;
        }
    }
}
