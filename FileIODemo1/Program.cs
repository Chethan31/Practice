//Collect person name and store in file

using System.IO;

ReadData();
SaveData();
ReadData();

static void ReadData()
{
    StreamReader reader = new StreamReader("D:/NameList.txt");

    while (!reader.EndOfStream)
    {
        string name = reader.ReadLine();
        Console.WriteLine(name);
    }

    //string AllNames = reader.ReadToEnd();
    //Console.WriteLine(AllNames);

    reader.Close();
    
}




static void SaveData()
{
    StreamWriter writer = null;
    try
    {
        Console.WriteLine("Enter Person name:");
        string pName = Console.ReadLine();

        writer = new StreamWriter("D:/NameList.txt", true);
        writer.WriteLine(pName);

       // writer.Close();
    }
    catch(Exception ex)
    {
       // writer.Close();
    }
    finally // important in file program
    {
        writer.Close();
    }
}