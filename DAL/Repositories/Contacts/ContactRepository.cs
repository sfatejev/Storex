using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.Interfaces.Contacts;
using Domain.Contacts;

namespace DAL.Repositories.Contacts
{
    public class ContactRepository : EFRepository<Contact>, IContactRepository
    {
        public ContactRepository(IDbContext dbContext) : base(dbContext)
        {
        }

        public List<Contact> GetAllUserContacts(int userId)
        {
            return DbSet.Where(u => u.Person.UserId == userId)
                .Include(p => p.Person)
                .Include(t => t.ContactType)
                .OrderBy(p => p.Person.Lastname)
                .ThenBy(p => p.Person.Firstname)
                .ToList();
        }

        public Contact GetUserContactById(int contactId, int userId)
        {
            return DbSet.FirstOrDefault(x => x.ContactId == contactId && x.Person.UserId == userId);
        }
    }
}