// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Threading.Channels;


//task1
Console.WriteLine("Hello Weebshit");
//task1 alternate
string hw = "hello weebshitters";
Console.WriteLine(hw);


//task2
Console.WriteLine("\n" +
    "task2");

int loop1 = 1;
do
{
    Console.WriteLine(hw +" " +loop1);
    loop1++;
}
while (loop1 <= 25);


//task3
Console.WriteLine("\n" +
    "task3");
//arrays
//deklaracja listy
ArrayList AnaL = new ArrayList();
AnaL.Add("Weebshit");
AnaL.Add("General");
AnaL.Add("Memes");
AnaL.Add("Gacha");
//loop 
foreach(var fallus in AnaL)
{
    Console.WriteLine(fallus);
}

//task3 alternative - List
Console.WriteLine("\n" +
    "task3.1 list edition");
    
    List<string> channels = new List<string>();
    channels.Add("Weebshit");
    channels.Add("General");
    channels.Add("Memes");
    channels.Add("Gacha");
    channels.Add("Vidya");
//trying different kind of loop
int count1 = 0;
while (count1 < channels.Count())
    {
        Console.WriteLine(count1 + ". " + channels[count1]);

            count1++;
    }
//task4 using the list from 3.1 
Console.WriteLine("\n" +
    "task4\n");

count1 = 0;
while(count1 < channels.Count())
{
    if(count1 % 2 == 0)
    {
        Console.WriteLine(count1 + ". " + channels[count1]);

        
    }
    count1++;
}
//task5
Console.WriteLine("\n" +
    "task5\n");


static int FibonCiag(int fib1) 
    {
        int countfib = 1;
        fib1 = 0;
        int fib2 = 1;
        while (countfib <= 5)
        {
            Console.WriteLine(fib1);
            fib1 = fib1 + fib2;
            Console.WriteLine(fib2);
            fib2 = fib2 + fib1;
            countfib++;
            
        }

        return fib1;
    }
int result1 = 0;
FibonCiag(result1);
   














