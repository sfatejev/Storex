using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Domain.Contacts;

namespace DAL
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<StorexDbContext>
    {
        protected override void Seed(StorexDbContext dbContext)
        {
            var autoDetectChangesEnabled = dbContext.Configuration.AutoDetectChangesEnabled;
            dbContext.Configuration.AutoDetectChangesEnabled = false;

            //seed methods here
            //SeedContacts(dbContext);
            //---
            //---
            //end of seed methods

            //restoring state
            dbContext.Configuration.AutoDetectChangesEnabled = autoDetectChangesEnabled;
            base.Seed(dbContext);
        }

        #region SeedContacts

        private void SeedContacts(StorexDbContext dbContext)
        {
            dbContext.ContactTypes.Add(new ContactType
            {
                ContactTypeName = "Skype",
                ContactTypeDescription = "P2P internet voice and video chat",
                ContactTypeActive = true,
                CreatedBy = "Storex",
                CreatedAtDT = DateTime.Now
            });

            dbContext.ContactTypes.Add(new ContactType
            {
                ContactTypeName = "E-mail",
                ContactTypeDescription = "Typical web-mail service",
                ContactTypeActive = true,
                CreatedBy = "Storex",
                CreatedAtDT = DateTime.Now
            });

            dbContext.ContactTypes.Add(new ContactType
            {
                ContactTypeName = "Phone",
                ContactTypeDescription = "All types of contact phones",
                ContactTypeActive = true,
                CreatedBy = "Storex",
                CreatedAtDT = DateTime.Now
            });

            var emailId = dbContext.ContactTypes.FirstOrDefault(t => t.ContactTypeName == "E-mail")?.ContactTypeId ?? 0;
            var skypeId = dbContext.ContactTypes.FirstOrDefault(t => t.ContactTypeName == "Skype")?.ContactTypeId ?? 0;
            var phoneId = dbContext.ContactTypes.FirstOrDefault(t => t.ContactTypeName == "Phone")?.ContactTypeId ?? 0;
        }

        #endregion

    }
}