using FileIODemo2.Entities;
using FileIODemo2.DomainException;

namespace FileIODemo2.DataLayer
{
    public class ContactsRepository : IContactsRepository
    {
        private readonly string fileName = "D:/Contact-list.txt";
        public List<Contact> GetAllContacts()
        {
            StreamReader reader = null;
            List<Contact> contacts = new List<Contact>();
            try
            {
                reader = new StreamReader(fileName);
                while (!reader.EndOfStream)
                {
                    //read line by line
                    string line = reader.ReadLine();
                    string[] data = line.Split(',');
                    // convert line into contact object
                    Contact contact = new Contact();
                    contact.ContactId = int.Parse(data[0]);
                    contact.Name = data[1];
                    contact.EmailId = data[2];
                    contact.MobileNo = data[3];
                    contact.Location = data[4];
                    //add contact obj into list
                    contacts.Add(contact);               
                }
            }
            catch (Exception ex)
            {
                UnableToReadContactException ex1 = new UnableToReadContactException("Unable to read Contact information, try again", ex);
                throw ex1;//re throw
            }
            finally 
            {
                if (reader != null)
                    reader.Close(); 
            }
            //return the list
            return contacts;
        }

        public void saveContact(Contact contactToSave)
        {
            StreamWriter Writer = null;
            try
            {
                // open the writer stream
                Writer = new StreamWriter(fileName, true);
                string contactCSV = $"{contactToSave.ContactId},{contactToSave.Name}," +
                    $"{contactToSave.EmailId},{contactToSave.MobileNo},{contactToSave.Location}";
                Writer.WriteLine(contactCSV);
            }
            catch(Exception ex)
            {
                UnableToSaveContactException ex1 = new UnableToSaveContactException("Contact information is not saved, try again", ex);
                throw ex1;//re throw
            }
            finally
            {
                if(Writer != null)
                    Writer.Close();
            }

        }
    }
}
