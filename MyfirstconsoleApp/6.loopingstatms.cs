using System;

internal class loopingstatms
{
    static void Main()
    {
        // for loop
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("For Loop Iteration: " + i);
        }
        // while loop
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine("While Loop Iteration: " + j);
            j++;
        }
        // do-while loop
        int k = 1;
        do
        {
            Console.WriteLine("Do-While Loop Iteration: " + k);
            k++;
        } while (k <= 5);




       string [] fruits = { "Apple", "Banana", "Cherry" };
        foreach (var fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }

        for( int p = 1; p <= 10; p++)
        {
            Console.WriteLine(p);
           
            
        }
        //break statement and continue statement

        for(int q=1;q<=10;q++)
        {
            if(q==5)
            {
                break; // exit the loop when q is 5
            }
            Console.WriteLine(q);
        }
        for(int r=1;r<=10;r++)
        {
            if(r==5)
            {
                continue; // skip the iteration when r is 5
            }
            Console.WriteLine( r);
        }


        //break and continue within one loop
        for(int s=1;s<=10;s++)
        {
            if(s==3)
            {
                continue; // skip when s is 3
               
            }
            if(s==7)
            {
                break; // exit loop when s is 7
            }
            Console.WriteLine(s);
        }


    }



}