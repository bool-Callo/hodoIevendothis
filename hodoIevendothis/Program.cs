// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;


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
    Console.WriteLine(fallus + "\n");
}

//task3 alternative
Console.WriteLine("\n" +
    "task3.1");




