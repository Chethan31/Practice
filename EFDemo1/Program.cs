using EFDemo1.Data;
using EFDemo1.Entities;

namespace EFDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Add Contact");
                Console.WriteLine("2.Edit Contact");
                Console.WriteLine("3.Delete Contact");
                Console.WriteLine("4.Display Contact");
                Console.WriteLine("5.Exit");
                Console.Write("Enter your choice:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Create();
                        Console.WriteLine("Contact Saved...");
                        break;
                    case 2:
                        Edit();
                        Console.WriteLine("Edit Done...");
                        break;
                    case 3:
                        Delete();
                        Console.WriteLine("Contact deleted...");
                        break;
                    case 4:
                        Fetch();
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void Delete()
        {
            // Delete a Contact
            int id;
            Console.Write("Enter the ID to be deleted:");
            id = int.Parse(Console.ReadLine());
            ContactsDBContext db = new ContactsDBContext();
            //Contact contactToDelete = (from c in db.contacts
            //                          where c.ContactId == 1
            //                          select c).FirstOrDefault();

            var contactToDelete = db.Contacts.Find(id);
            db.Contacts.Remove(contactToDelete);
            db.SaveChanges();
        }

        private static void Edit()
        {
            //Edit Rahul Mob no
            //get the RAhul's obj
            int id;
            Console.Write("Enter the ID to be Edited:");
            id = int.Parse(Console.ReadLine());
            char ch;
            string edit;
            do
            {
                Console.WriteLine($"Edit Contact Id={id}:");
                Console.WriteLine("1.Name");
                Console.WriteLine("2.Email");
                Console.WriteLine("3.Mobile Number");
                Console.WriteLine("4.Location");
                int c;
                Console.Write("Enter your choice to be edited:");
                c = int.Parse(Console.ReadLine());
                ContactsDBContext db = new ContactsDBContext();
                var contactToedit = db.Contacts.Find(id);
                switch (c)
                {
                    case 1:
                        Console.Write("Enter the Name:");
                        edit = Console.ReadLine();
                        contactToedit.Name = edit;
                        break;
                    case 2:
                        Console.Write("Enter the Email:");
                        edit = Console.ReadLine();
                        contactToedit.Email = edit;
                        break;
                    case 3:
                        Console.Write("Enter the Mobile Number:");
                        edit = Console.ReadLine();
                        contactToedit.Mobile = edit;
                        break;
                    case 4:
                        Console.Write("Enter the Location:");
                        edit = Console.ReadLine();
                        contactToedit.Location = edit;
                        break;
                    default:
                        break;
                }
                db.SaveChanges();
                Console.Write("Do you wish to continue editing (Y/N):");
                ch = char.Parse(Console.ReadLine());
            } while (ch == 'y' || ch == 'Y');



            //ContactsDbContext db = new ContactsDbContext();
            //var rahul = (from c in db.contacts
            //             where c.Name == "Rahul"
            //             select c).FirstOrDefault();

            //rahul.Phone = "12349876";
            //db.SaveChanges();
        }

        private static void Create()
        {
            //Create new Contact
            //
            Console.WriteLine("Create Contact Details:");
            ContactsDBContext db = new ContactsDBContext();
            Contact c = new Contact();
            Console.Write("Enter Contact Name:");
            c.Name = Console.ReadLine();
            Console.Write("Enter Email:");
            c.Email = Console.ReadLine();
            Console.Write("Enter Mobile:");
            c.Mobile = Console.ReadLine();
            Console.Write("Enter Location:");
            c.Location = Console.ReadLine();

            db.Add(c);
            db.SaveChanges();
        }

        private static void Fetch()
        {
            //fetch all contacts
            ContactsDBContext db = new ContactsDBContext();
            //linq to entities

            var contacts = from c in db.Contacts
                           select c;
            Console.WriteLine("Contact Details:");
            Console.WriteLine("ID\tName\tEmail\tPhone\tLocation");
            foreach (var item in contacts)
            {
                Console.WriteLine($"{item.ContactID}\t{item.Name}\t{item.Email}\t{item.Mobile}\t{item.Location}");
            }
        }
    }
}