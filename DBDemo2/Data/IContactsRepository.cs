using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBDemo2.Entites;

namespace DBDemo2.Data
{
    public interface IContactsRepository
    {
        void Save(Contact contactToSave);
        void Delete(int id);

        Contact GetContact(int id);

        List<Contact> GetAllContacts();

        void Update(Contact contactToUpdate);

        List<Contact> GetContactsByLocation(string location);

        Contact GetContactByName(string nameToSearch);

        int GetContactCount();
    }
}
