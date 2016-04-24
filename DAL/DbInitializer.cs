using System.Data.Entity;

namespace DAL
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<StorexDbContext>
    {
        protected override void Seed(StorexDbContext dbContext)
        {
            var autoDetectChangesEnabled = dbContext.Configuration.AutoDetectChangesEnabled;
            dbContext.Configuration.AutoDetectChangesEnabled = false;

            //seed methods here
            //---
            //---
            //---
            //end of seed methods

            //restoring state
            dbContext.Configuration.AutoDetectChangesEnabled = autoDetectChangesEnabled;
            base.Seed(dbContext);
        }
    }
}