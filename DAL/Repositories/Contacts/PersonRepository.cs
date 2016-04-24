using System.Collections.Generic;
using System.Data.Entity;
using DAL.Interfaces.Contacts;
using Domain.Contacts;
using System.Linq;

namespace DAL.Repositories.Contacts
{
    public class PersonRepository : EFRepository<Person>, IPersonRepository
    {
        public PersonRepository(IDbContext dbContext) : base(dbContext)
        {
        }

        public List<Person> GetAllUserPersons(int userId)
        {
            return DbSet.Where(p => p.UserId == userId)
                .OrderBy(o => o.Lastname)
                .ThenBy(o => o.Firstname)
                .Include(c => c.Contacts)
                .ToList();
        }

        public Person GetUserPerson(int personId, int userId)
        {
            return DbSet.FirstOrDefault(p => p.PersonId == personId && p.UserId == userId);
        }
    }
}