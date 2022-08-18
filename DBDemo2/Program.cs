// Seusing DBDemo1.Data;
using DBDemo2.Entites;
using DBDemo2.Data;
using System.Data.SqlClient;

namespace DBDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contact Manager
            // Save
            // Select
            // Delete
            // Edit

            // Code First
            // DB First

            // 1. Choose the database/create 
            // 2. Create table
            // Collect contact information from user and insert into db

            while (true)
            {
                Console.WriteLine("My Contacts Management App");
                Console.WriteLine("1. Save Contact");
                Console.WriteLine("2. Delete Contact");
                Console.WriteLine("3. Search Contact");
                Console.WriteLine("4. Display All Contacts");
                Console.WriteLine("5. Contact Count");
                Console.WriteLine("6. Display All Contacts By Location");
                Console.WriteLine("7. Display Contact By Name Search");
                Console.WriteLine("8. Update Contact");
                Console.WriteLine("9. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AcceptContact(); break;
                    case 2: DeleteContact(); break;
                    case 3: SearchContact(); break;
                    case 4: DisplayAllContacts(); break;
                    case 5: GetCount(); break;
                    case 6: DisplayAllContactsByLocation(); break;
                    case 7: DisplayContactName(); break;
                    case 8: UpdateContact(); break;
                    default:
                        break;
                }
            }


        }

        static void DisplayAllContacts()
        {
            IContactsRepository repo = new ContactRepository();
            List<Contact> contacts = repo.GetAllContacts();

            Console.WriteLine("Contact Id \t Name \t Mobile \t Email \t Location");

            foreach (Contact c in contacts)
            {
                Console.WriteLine($"{c.ContactID} \t {c.Name.Trim()} \t {c.Mobile.Trim()}\t{c.Email.Trim()}\t{c.Location.Trim()}");
            }
        }
        static void DisplayAllContactsByLocation()
        {
            Console.Write("Enter the Location:");
            string loc = Console.ReadLine();
            IContactsRepository repo = new ContactRepository();
            List<Contact> contacts = repo.GetContactsByLocation(loc);

            Console.WriteLine("Contact Id \t Name \t Mobile \t Email \t Location");

            foreach (Contact c in contacts)
            {
                Console.WriteLine($"{c.ContactID} \t {c.Name.Trim()} \t {c.Mobile.Trim()}\t{c.Email.Trim()}\t{c.Location.Trim()}");
            }
        }
        static void SearchContact()
        {
            Console.WriteLine("Enter Contact ID to search");
            int cid = int.Parse(Console.ReadLine());
            IContactsRepository repo = new ContactRepository();
            Contact c = repo.GetContact(cid);

            Console.WriteLine($"Contact ID : {c.ContactID}");
            Console.WriteLine($"Name : {c.Name}");
            Console.WriteLine($"Mobile : {c.Mobile}");
            Console.WriteLine($"Email : {c.Email}");
            Console.WriteLine($"Location : {c.Location}");
        }
        static void DisplayContactName()
        {
            Console.WriteLine("Enter Name to search");
            string name = Console.ReadLine();
            IContactsRepository repo = new ContactRepository();
            Contact c = repo.GetContactByName(name);

            Console.WriteLine($"Contact ID : {c.ContactID}");
            Console.WriteLine($"Name : {c.Name}");
            Console.WriteLine($"Mobile : {c.Mobile}");
            Console.WriteLine($"Email : {c.Email}");
            Console.WriteLine($"Location : {c.Location}");
        }
        static void DeleteContact()
        {
            Console.Write("Enter Contact id to delete");
            int id = int.Parse(Console.ReadLine());
            IContactsRepository repo = new ContactRepository();
            repo.Delete(id);
        }

        static void AcceptContact()
        {
            Contact c = new Contact();
            Console.Write("Enter Contact Name: ");
            c.Name = Console.ReadLine();
            Console.Write("Enter Mobile: ");
            c.Mobile = Console.ReadLine();
            Console.Write("Enter Email: ");
            c.Email = Console.ReadLine();
            Console.Write("Enter Location: ");
            c.Location = Console.ReadLine();
            IContactsRepository repo = new ContactRepository();
            repo.Save(c);
        }
        static void UpdateContact()
        {
            Contact c = new Contact();
            Console.Write("Enter Contact ID to Update: ");
            c.ContactID = int.Parse(Console.ReadLine());
            Console.Write("Enter Contact Name: ");
            c.Name = Console.ReadLine();
            Console.Write("Enter Mobile: ");
            c.Mobile = Console.ReadLine();
            Console.Write("Enter Email: ");
            c.Email = Console.ReadLine();
            Console.Write("Enter Location: ");
            c.Location = Console.ReadLine();
            IContactsRepository repo = new ContactRepository();
            repo.Update(c);
        }
        static void GetCount()
        {
            IContactsRepository repo = new ContactRepository();
            int count = repo.GetContactCount();
            Console.WriteLine("Total Contacts are:" + count);
        }
    }
}
