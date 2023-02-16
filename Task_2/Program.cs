// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Input the number");
int x = Convert.ToInt32(Console.ReadLine());

 if ( x/100 <1 )
  Console.WriteLine("третьей цифры нет");
    
 else {
       if  (x / 100 >= 1 && x / 100 < 10)
       {     
        int y = x % 10;
        Console.WriteLine(x+" "+"->"+" "+y);
       }
       
      else if ( x / 100 >= 10)
       {
       int numberIndex = 2;
       int index = x.ToString()[numberIndex] - '0';
       Console.WriteLine(x+" "+"->"+" "+index);
       }
      }      
      

         
    
    
