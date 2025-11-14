using System;




class datatypes
{
    static void Main()
    {
        string name = "bhanu prakash raju";
        Console.WriteLine(name);


        char grade = 'A';
        Console.WriteLine(grade);

        
        string studentName = "Bhanu prakash raju";
        int lname = studentName.Length;
        Console.WriteLine(lname);


        string animal = "Elephant";
        Console.WriteLine( animal.Length);


        string city = "Hyderabad";
        string location=city.ToUpper();
        Console.WriteLine(location);


        string country = "INDIA";
        Console.WriteLine(country.ToLower());


        string senctence = "    I love you";
        string trimmedSentence = senctence.Trim();
        Console.WriteLine(trimmedSentence);

        string phrase = "Hello, World!";
        bool containsWorld = phrase.Contains("Hello");
        Console.WriteLine(containsWorld);


        string name5 = "****John****";
        string uName5 = name5.Trim('*');  // Calling Trim() method by passing the * argument.
        Console.WriteLine($"uName5 {uName5}");




        string text="************bhanu prakash raju*******";
        string mess=text.Trim('*');
        Console.WriteLine(text);
        Console.WriteLine(mess);


        string fruit = "apple";
        string nfruit = fruit.PadLeft(10,'-');
        Console.WriteLine(nfruit);

        string Rfruit= fruit.PadRight(10,'-');
        Console.WriteLine(Rfruit);


        string username = "bhanu prakash";
        int password = 2808;
        bool isequal = username.Equals(password);
        Console.WriteLine(isequal);




        string statement = "Hello everyone, welcome to the world of C# programming.";
        string status = statement.Substring(3);
        Console.WriteLine(status);


        string val=statement.Replace("C#","Java");
        Console.WriteLine(val);


        string data="Apple,Banana,Orange,Grapes";
        string dataa=data.Remove(10);
        Console.WriteLine(dataa);


        //int price= 100;
        // double value = 6.5;
        // double total=price*value;
        // string messed=string.Format("the price of itam {0} and value of the item {1} price, total");
        // Console.WriteLine(messed);




        int quanitty = 12;  // 10pens
        double price = 9.99; //pricevalue

        double finalOuput = quanitty * price;


        //Client message : "Hey User ... You are having the 10 pens and total cost is 11.56 * quantity";

        string message = string.Format("Hey User ... You are having the {0} pens and total cost is {1}",
                                                      quanitty, finalOuput);

        Console.WriteLine(message);




        //var and dynamic keywords difference
        var data1 = "Bhanu prakash raju";
        Console.WriteLine(data1);
        data1 = "Raju bhanu prakash";
        Console.WriteLine(data1);
        //data1 = 12345; // Compile-time error: Cannot assign an integer to a string variable

        //Console.WriteLine(data1);

        dynamic data2 = "Bhanu prakash raju";
        Console.WriteLine(data2);
        data2 = 12345; // No compile-time error: dynamic type allows reassignment to different types
        Console.WriteLine(data2);


        //type conversion difference between implicit and explicit
        //implicit conversion
        int num1 = 100;
        double dnum1 = num1; // Implicit conversion from int to double
        Console.WriteLine(dnum1);


        //explicit conversion
        double dnum2 = 9.78;
        int num2 = (int)dnum2; // Explicit conversion from double to int
        Console.WriteLine(num2);








    }
}