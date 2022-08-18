using System.IO;

//GetAllFolders();
GetSubDirectories();

static void GetAllFiles()
{
    string[] files = Directory.GetFiles(@"D:\");
    foreach (var file in files)
    {
        Console.WriteLine(file);
       // File.Delete(file);
    }
}
static void GetAllFolders()
{
    //string[] folders = Directory.GetDirectories(@"D:\");
    //foreach (var folder in folders)
    //{
    //    Console.WriteLine(folders);
    //    // File.Delete(file);
    //}
    //Console.WriteLine(Directory.GetDirectoryRoot(@"D:\Wallpaper"));
    string[] drive = Directory.GetLogicalDrives();
    foreach (var d in drive)
    {
        Console.WriteLine(d);
    }
}

static void GetDriveInfo()
{
    DriveInfo[] drive = DriveInfo.GetDrives();
    foreach (var d in drive)
    {
        Console.WriteLine(d.Name);
        Console.WriteLine(d.AvailableFreeSpace);
    }
}

static void Search()
{
    Console.Write("Enter the File Name:");
    string SF = Console.ReadLine();


}
//string root = @"D:\OO LABS to Participants\OO LABS to Participants";
//Directory.SetCurrentDirectory(root);
//Console.WriteLine(Directory.GetCurrentDirectory());


static void GetSubDirectories()
{
    string root = @"D:\";
    string[] subdirectoryEntries = Directory.GetDirectories(root);
    //foreach (var subdirectoryEntry in subdirectoryEntries)
    //    Console.WriteLine(subdirectoryEntries);
    // Loop through them to see if they have any other subdirectories  
    foreach (string subdirectory in subdirectoryEntries)
        LoadSubDirs(subdirectory);
}
static void LoadSubDirs(string dir)
{
    Console.WriteLine(dir);
    string[] subdirectoryEntries = Directory.GetDirectories(dir);
    foreach (string subdirectory in subdirectoryEntries)
    {
        LoadSubDirs(subdirectory);
    }
}