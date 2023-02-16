// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Input the number");
int x = Convert.ToInt32(Console.ReadLine()); 

if ( x/100 == 0 || x/100 > 9)
   Console.WriteLine("This number is  incorrect");
else {
   int y = (x / 10)%10;
    Console.WriteLine(x+" "+"->"+" "+y);
   }