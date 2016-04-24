using System.Collections.Generic;
using Domain.Contacts;

namespace DAL.Interfaces.Contacts
{
    public interface IContactRepository : IEFRepository<Contact>
    {
        List<Contact> GetAllUserContacts(int userId);
        Contact GetUserContactById(int contactId, int userId);
    }
}