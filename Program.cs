//  Напишите программу, которая на вход принимает его квадрат (число умноженное на само себя)
//  Например:
//  4 -> 16
//  -3 -> 9
//  -7 -> 49

//  Console.Write("Введите число: "); // 1. Приглашение к вводу
//  int number = Convert.ToInt32(Console.ReadLine()); // 2. Считывание данных с консоли и преобразование в тип int
//  string? str = Console.ReadLine(); // 2.1 Считываем данные с консоли 
//  int number = Convert.ToInt32(str);// 2.2 Конвертация в число 
//  Console.WriteLine(number+number); // 3. Вывод на экран number ^ 2


//   Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//   a = 25, b = 5 -> да
//   a = 2, b = 10 -> нет
//   a = 9, b = -3 -> да
//   a = -3 b = 9 -> нет


//   int a = 25;
//   int b = 5;

//   if (a == (b * b))
//   {
//   Console.WriteLine("Да");
//   }
//   else
//   {
//       Console.WriteLine("Нет");
//   }


//   Console.Write("введите первое число");
//   int number1 = Convert.ToInt32(Console.ReadLine()) ;
//   Console.Write("введите второе число");
//   int number2 = Convert.ToInt32(Console.ReadLine()) ;
//   if(number1 == number2 * number2) {
//   Console.Write("Yes");
//   }
//   else
//   {
//   Console.Write("No");
//   }


//   Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//   3 -> Среда
//   5 -> Пятница

//   Console.WriteLine("Введите число дна недели: ");
//   int number = Convert.ToInt32 (Console.ReadLine());
//   if(number <= 7 & number >= 1)
//    {
//    if (number == 1)
//    {
//        Console.WriteLine ("Понедельник");
//     }
//     if (number == 2)
//     {
//        Console.WriteLine("Вторник");
        
//      }
//      if (number == 3)
//      {
//           Console.WriteLine("Среда");
//      }
//      if (number == 4)
//      {
//          Console.WriteLine("Четверг");
//      }
//       if (number == 5)
//      {
//      Console.WriteLine("Пятница");
//      }
//      if (number == 6)
//      {
//         Console.WriteLine("Суббота");
//      }
//      if (number == 7)
//      {
//         Console.WriteLine("Воскресенье");
//      }

//      }
//      else 
//      {
//         Console.WriteLine("Такого дня не существует");
//      }


//  Задача 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//  4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//  2 -> " -2, -1, 0, 1, 2"


// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// number = Math.Abs(number);
// int i = -number;
// while(number >= i )
// {
//     Console.WriteLine (i++);
// }

// Задача 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(number % 10);