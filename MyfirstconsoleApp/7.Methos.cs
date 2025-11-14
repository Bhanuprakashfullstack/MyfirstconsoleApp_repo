using System;
class Methods
{
    static void Main()
    {
        //studentdetails();
        //addnumbers();
        //greetuser("Bhanu prakash raju");
        //Zoopark("Tirupathi Zoo park","gandhi road");
        //displayinfo("Bhanu prakash raju", 22, "Rjmpt");
        Allmethods();
    }

    static void studentdetails()
    {
        Console.WriteLine("Bhanu prakash raju");
        Console.WriteLine("rollno:15");
        Console.WriteLine("branch:cse");
  
    }


    static void addnumbers()
    {
        int a = 10;
        int b = 20;
        int sum = a + b;
        Console.WriteLine("Sum: " + sum);
    }



    static void greetuser(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }


    static void Zoopark(string zooloc, string address)
    {
        string animal1 = "Lion";
        string animal2 = "Tiger";
        int age1 = 5;
        int age2 = 4;
        Console.WriteLine(animal1);
        Console.WriteLine("Age: " + age1);
        Console.WriteLine(animal2);
        Console.WriteLine("Age: " + age2);
        Console.WriteLine( zooloc);
        Console.WriteLine(address);
    }


    static void displayinfo(string name, int age, string city)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
    }


    static void Allmethods()
    {
        studentdetails();
        addnumbers();
        greetuser("Bhanu prakash raju");
        Zoopark("Tirupathi Zoo park", "gandhi road");
        displayinfo("Bhanu prakash raju", 22, "Rjmpt");
    }

}

