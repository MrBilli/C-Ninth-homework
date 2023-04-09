// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNaturalNums(int num)
// {   
//     if(num > 1)
//     Console.Write(num + ", ");
//     else
//     Console.Write(num);
//     if(num > 1) ShowNaturalNums(num - 1);
// }

// Console.WriteLine("Введите число начиная с которого до 1 будут показаны все натуральные числа:");

// double num = Convert.ToDouble(Console.ReadLine());

// int naturalNumber = Convert.ToInt32(num);

// ShowNaturalNums(naturalNumber);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int RecieveSumFromMtoN(int m, int n, int sum)
// {
//     if(n > m) 
//     {
//         int plus = sum;
//         sum += m + n;
//         Console.WriteLine($"{m} + {n} + {plus} = {sum}");
//         return RecieveSumFromMtoN(m + 1, n - 1, sum);
//     }
//     if(n == m) 
//     {
//         int plus = sum;
//         sum += m;
//         Console.WriteLine($"{plus} + {m} = {sum}");
//         return RecieveSumFromMtoN(m + 1, n - 1, sum);
//     }  
//     return sum;
// }

// int sum = 0;

// Console.WriteLine("Нахождение суммы натуральных элементов от N до M");

// Console.WriteLine("Введите наименьшее число:");

// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите наибольшее число:");

// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {RecieveSumFromMtoN(m, n, sum)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int ack(int a, int b)
// {
//    if(a == 0) return b + 1;
//    if(b == 0) return ack(a - 1, 1);
//     return ack(a - 1, ack (a, b - 1));
// }

// Console.WriteLine("Функция Аккермана");

// Console.WriteLine("Введите число a:");

// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число b:");

// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Результат работы функции = {ack(a, b)}");
