using ScottConsolenAnwendung2._1;
using System;


DBAccess db = new DBAccess();

int count = 0;
while (true)
{
    if (count == 0)
    {
        db.ColorText();
        Console.WriteLine(db.GetAllDepts());
    }
    Console.WriteLine("(C)reate (R)ead (U)pdate (D)elete");
    string menu = Console.ReadLine();
    if (menu.ToUpper() == "C")
    {
        Console.WriteLine("deptno?");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("dname?");
        string dn = Convert.ToString(Console.ReadLine());
        Console.WriteLine("loc?");
        string l = Convert.ToString(Console.ReadLine());
        db.CreateDept(d, dn, l);
        db.ColorText();
    }
    else if (menu.ToUpper() == "R")
    {
        Console.WriteLine("deptno?");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(db.ReadDept(d));
        db.ColorText();
    }
    else if (menu.ToUpper() == "U")
    {
        Console.WriteLine("deptno?");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("dname?");
        string dn = Console.ReadLine();
        Console.WriteLine("loc?");
        string l = Console.ReadLine();
        db.UpdateDept(d, dn, l);
        db.ColorText();
    }
    else if (menu.ToUpper() == "D")
    {
        Console.WriteLine("deptno?");
        int d = Convert.ToInt32(Console.ReadLine());
        db.DeleteDept(d);
        db.ColorText();
    }
    else
    {
        Console.WriteLine(db.GetAllDepts());
        db.ColorText();
    }
    

    count++;
}