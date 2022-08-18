using System.Diagnostics;

class Program {
    public static void Main()
    {
        ProcessManager PM = new ProcessManager();
        //Client 1
        //// PM.ShowProcessList(Program.FilterByNone);

        //Client 2
        //PM.ShowProcessList("S");
        //// PM.ShowProcessList(Program.FilterByName);

        //Client 3
        //PM.ShowProcessList(50*1024*1024);//memomry mb 50mb
        ////FilterDelegate f = new FilterDelegate(new Program().FilterBySize);
        ////PM.ShowProcessList(f);

        //New update using delegate keyword
        ////PM.ShowProcessList(delegate (Process p)
        ////{
        ////    return p.WorkingSet64 >= (50 * 1024 * 1024);
        ////});

        //Lambda
        //Lambda Statement
        ////PM.ShowProcessList((Process p)=>//lambda symbol
        ////{
        ////    return p.WorkingSet64 >= (50 * 1024 * 1024);
        ////});
        //Lambda Expression first
        ////PM.ShowProcessList((Process p) =>
        ////     p.WorkingSet64 >= 50 * 1024 * 1024
        ////);

        //Lambda Expression second
        //Client 3
       // PM.ShowProcessList(p => p.WorkingSet64 >= 50 * 1024 * 1024);
        //Client 1
       // PM.ShowProcessList(p => true);
        //Client 2
        PM.ShowProcessList(p => p.ProcessName.StartsWith("s"));
    }
    //public static bool FilterByNone(Process p)
    //{
    //    return true;
    //}
    //public static bool FilterByName(Process p)
    //{
    //    if (p.ProcessName.StartsWith("s"))
    //        return true;
    //    else
    //        return false;
    //}
    //public bool FilterBySize(Process p)
    //{
    //    return p.WorkingSet64 >= (50 * 1024 * 1024);
    //}
}

public delegate bool FilterDelegate(Process p);

public class ProcessManager
{
    //public void ShowProcessList()
    //{
    //    foreach(Process p in Process.GetProcesses())
    //    {
    //        Console.WriteLine(p.ProcessName);
    //    }
    //}
    public void ShowProcessList(FilterDelegate filter)
    {
        foreach (Process p in Process.GetProcesses())
        {
           // Program prg = new Program();
            if(filter(p))
                Console.WriteLine(p.ProcessName);
            // if(p.ProcessName.StartsWith(s))

        }
    }
    //public void ShowProcessList(long size)
    //{
    //    foreach (Process p in Process.GetProcesses())
    //    {
    //        if (p.WorkingSet64 >= size)
    //            Console.WriteLine(p.ProcessName);
    //    }
    //}
}