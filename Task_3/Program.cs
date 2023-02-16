// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



Console.WriteLine("Input the number");
int a = Convert.ToInt32(System.Console.ReadLine());

switch (a) 
{
      case 1:
           Console.WriteLine("1 -> нет"); //"Monday"
           break;
      case 2:
           Console.WriteLine("2 -> нет"); //"Tuesday"
           break;
      case 3:
           Console.WriteLine("3 -> нет"); //"Wednesday"
           break;
      case 4:
           Console.WriteLine("4 -> нет"); //"Thursday"
           break;
      case 5:
           Console.WriteLine("5 -> нет"); //"Friday"
           break;
      case 6:
           Console.WriteLine("6 -> да"); //"Saturday"
           break;
      case 7:
           Console.WriteLine("7 -> да");  //"Sunday"
           break;
      default:
           Console.WriteLine("There is no such a weekday");
           break;
}