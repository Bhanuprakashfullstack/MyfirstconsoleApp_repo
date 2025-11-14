using System;

internal class condtionalstatms

{
    static void Main()
    {
        int number = 10;
        // if statement
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        // if-else statement
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
        // if-else if-else statement
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }


        string name = "Bhanu";
        if (name == "Bhanu")
        {
            Console.WriteLine("Welcome Bhanu!");
        }
        else
        {
            Console.WriteLine("You are not Bhanu.");
        }

        int marks = 35;
        if(marks<35)
        {
            Console.WriteLine("fail");
        }
        else if(marks==35)
        {
            Console.WriteLine("just pass");
        }
        else if(marks>35 && marks<60)
        {
            Console.WriteLine("second class");
        }
        else if(marks>=60 && marks<75)
        {
            Console.WriteLine("first class");
        }
        else if(marks>=75 && marks<=100)
        {
            Console.WriteLine("distinction");
        }
        else
        {
          Console.WriteLine("fail better luck next time");
        }



        string animalname = "lion";
        if(animalname=="lion")
        {
            Console.WriteLine("king of the jungle");
        }
        else if(animalname=="elephant")
        {
            Console.WriteLine("largest land animal");
        }
        else if(animalname=="tiger")
        {
            Console.WriteLine("big cat");
        }
        else
        {
            Console.WriteLine("unknown animal");
        }







    }
}

