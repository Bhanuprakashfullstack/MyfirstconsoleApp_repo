using System;
class operations
{
    static void Main()
    {
        //operations
        //arthmetic operations
        int a = 10;
        int b = 20;
        int sum = a + b;
        Console.WriteLine(sum);

        int diff = b - a;
        Console.WriteLine(diff);

        int prod = a * b;
        Console.WriteLine(prod);

        int div = b / a;
        Console.WriteLine(div);

        Console.WriteLine(div * div);

        //assignment operations
        int c = 30;
        c += 10; // c = c + 10
        Console.WriteLine(c);

        c -= 5; // c = c - 5
        Console.WriteLine(c);

        c -= 10;
        Console.WriteLine(c);

        //comparison operations
        int x = 50;
        int y = 60;
        Console.WriteLine(x == y); // false

        int m = 70;
        int n = 70;
        Console.WriteLine(m == n); // true

        Console.WriteLine(n);
        Console.WriteLine(m != n); // false

        Console.WriteLine(x > y); // false
        Console.WriteLine(y > x); // true
        Console.WriteLine(x < y); // true
        Console.WriteLine(y < x); // false

        Console.WriteLine(m >= n); // true
        Console.WriteLine(m <= n); // true

        //logical operations
        bool p = true;
        bool q = false;
        Console.WriteLine(p && q); // false

        Console.WriteLine(p || q); // true
        Console.WriteLine(!p); // false

        int age = 25;
        bool isAdult = age >= 18 && age <= 65;
        Console.WriteLine(isAdult); // true




    }
}
