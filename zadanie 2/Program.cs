using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задание 2 ");
        AllInfoProcess();
        Console.ReadKey();
    }

    static void AllInfoProcess()
    {
        var myProcess = from proc in Process.GetProcesses(".")
                        orderby proc.Id
                        select proc;
        Console.WriteLine("\n*** Текущие процессы ***\n");
        foreach (var p in myProcess)
            Console.WriteLine("-> PID: {0}\tName: {1}", p.Id, p.ProcessName);  
        Console.WriteLine("Первые 3 процесса");
        int id = 0;
        foreach (var p in myProcess)
            if (id < 3)
            {
                Console.WriteLine("-> PID: {0}\tName: {1}", p.Id, p.ProcessName);
                id++;
            }
    }
}