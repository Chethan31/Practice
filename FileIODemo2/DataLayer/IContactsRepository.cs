using FileIODemo2.Entities;

namespace FileIODemo2.DataLayer
{
    public interface IContactsRepository
    {
        void saveContact(Contact contactToSave);
        List<Contact> GetAllContacts();
    }
}
