using Database.Context;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Linq;

namespace Database.Extensions
{
    public static class DbContextExtension
    {

        public static bool AllMigrationsApplied(this ApiContext context)
        {
            var applied = context.GetService<IHistoryRepository>().GetAppliedMigrations().Select(m => m.MigrationId);

            var total = context.GetService<IMigrationsAssembly>().Migrations.Select(m => m.Key);

            return !total.Except(applied).Any();
        }

        public static void EnsureSeeded(this ApiContext context)
        {
            // Add constant variable
            //if (!context.ConstantVariables.Any())
            //{
                //var types = JsonConvert.DeserializeObject<List<ConstantVariable>>(File.ReadAllText($"wwwroot\\Seed\\ConstantVariables.json"));
                //context.AddRange(types);
                //context.SaveChanges();
            //}
        }
    }
}
