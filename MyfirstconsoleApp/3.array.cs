using System;
class array
    {
    static void Main()
        {
        int[] numbers = new int[5];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;
        Console.WriteLine("Array elements are:");
        for (int i = 0; i < numbers.Length; i++)
            {
            Console.WriteLine(numbers[i]);
        }

        string[] names = new string[10];
        names[0]="bhanu";
        names[1]="prakash";
        names[2]="raju";
        names[3] = "kala";
        Console.WriteLine(names[0]);
        foreach(var namee in names)
        {
            Console.WriteLine(namee);
        }



    }
}
