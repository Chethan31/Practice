using SavingBank;

Savings s1 = new Savings();
Current c1 = new Current();

Console.WriteLine("Create Acoount Number");
s1.accno = int.Parse(Console.ReadLine());
Console.WriteLine("Create Name");
s1.name = Console.ReadLine();
Console.WriteLine("Enter Pin Code");
s1.pinNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter gender");
s1.gender = Console.ReadLine();





Bank bank = new Bank();

