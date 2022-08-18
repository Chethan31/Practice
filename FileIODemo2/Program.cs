using FileIODemo2.DataLayer;
using FileIODemo2.Entities;

int choice = 0;
Console.WriteLine("Welcome to My Contacts Management System");
Console.WriteLine("-----------------------------------------");
IContactsRepository repo = new ContactsRepository();
while (choice != 4)
{
    try
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1.Create Contact");
        Console.WriteLine("2.View All Contacts");
        Console.WriteLine("3.Search by ID");
        Console.WriteLine("4.Exit");
        Console.Write("Enter Your Choice:");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Contact contact = CollectContactData();
                repo.saveContact(contact);
                Console.WriteLine("Contact Saved....");
                break;
            case 2:
                List<Contact> contact1 = repo.GetAllContacts();
                DisplayAllContacts(contact1); 
                break;
            case 3:
                List<Contact> contact2 = repo.GetAllContacts();
                Console.Write("Enter Id to be Searched:");
                int id=int.Parse(Console.ReadLine());
               // if (validId(contact2, id))
                    SearchbyID(contact2, id);
                //else
                //    Console.WriteLine("Entered Id Doesn't exist in Contacts.");
                break;
            case 4:
            default:
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static Contact CollectContactData()
{
    Contact c = new Contact();
    Console.Write("Enter Contact ID: ");
    c.ContactId = int.Parse(Console.ReadLine());
    Console.Write("Enter Contact Name: ");
    c.Name = Console.ReadLine();
    Console.Write("Enter Email ID: ");
    c.EmailId = Console.ReadLine();
    Console.Write("Enter Mobile Number: ");
    c.MobileNo = Console.ReadLine();
    Console.Write("Enter Location: ");
    c.Location = Console.ReadLine();
    return c;
}
static void DisplayAllContacts(List<Contact> contacts)
{
    Console.WriteLine("ID\tName\tEmail\tMobile\tLocation");
    foreach (Contact c in contacts)
    {
        Console.WriteLine($"{c.ContactId}\t{c.Name}\t{c.EmailId}\t{c.MobileNo}\t{c.Location}");
    }
}
static void SearchbyID(List<Contact> contacts,int Id)
{
    int f1 = 0;
    int f2 = 1;

    //Console.WriteLine("ID\tName\tEmail\tMobile\tLocation");
    foreach (Contact c in contacts)
    {
        if (c.ContactId == Id)
            if (f1 == 0) {
                Console.WriteLine("ID\tName\tEmail\tMobile\tLocation");
                f1++;
            }
            Console.WriteLine($"{c.ContactId}\t{c.Name}\t{c.EmailId}\t{c.MobileNo}\t{c.Location}");
        else {
            if (f2 == 1) {
                Console.WriteLine("Entered Id Doesn't exist in Contacts.");
                f1++;
            }
        }
    }
}
//static bool validId(List<Contact> contacts, int Id)
//{
//    int flag = 0;
//    foreach (Contact c in contacts)
//    {
//        if (c.ContactId != Id)
//            flag = 1;
//    }
//    if(flag==0)
//        return true;
//    else
//        return false;
//}
