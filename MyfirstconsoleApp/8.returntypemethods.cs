using System;
class ReturnTypeMethods
{
    static void Main()
    {
        string Empname = EmployeeName();
        Console.WriteLine("Employee Name: " + Empname);


        int empid = EmployeeID();
        Console.WriteLine(empid);


        string company = CompanyName();
        Console.WriteLine("Company Name: " + company);


        double sal = GetSalary();
        Console.WriteLine(sal);


    }

    static string EmployeeName()
    {
        string name = "Bhanu prakash raju";
        return name;
    }

    static int EmployeeID()
    {
        int id = 101;
        return id;
    }

    static string CompanyName()
    {
        return "Tech Solutions Inc.";
    }


    static double GetSalary()
    {
        double salary = 75000.50;
        return salary;
    }




}
