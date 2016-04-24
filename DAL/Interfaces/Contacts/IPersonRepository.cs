using System.Collections.Generic;
using Domain.Contacts;

namespace DAL.Interfaces.Contacts
{
    public interface IPersonRepository : IEFRepository<Person>
    {
        List<Person> GetAllUserPersons(int userId);
        Person GetUserPerson(int personId, int userId); 
    }
}