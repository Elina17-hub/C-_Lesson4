//РЕКУРСИЯ!!!! 
//Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// {
//     Console.Write("Введите значение М:");
//     int m = int.Parse(Console.ReadLine());
//     Console.Write("Введите значение N:");
//     int n = int.Parse(Console.ReadLine());

//     PrintNumbers(m, n);
// }
// void PrintNumbers(int current, int end)
// {
//     if (current <= end)
//     {
//         Console.WriteLine(current);
//         PrintNumbers(current + 1, end);
//     }
// }
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// {
//     Console.Write("Введите значение m:");
//     int m = int.Parse(Console.ReadLine());
//     Console.Write("Введите значение n:");
//     int n = int.Parse(Console.ReadLine());

//     int result = AckermannFunction(m, n);
//     Console.WriteLine($"Результат функции Аккермана для m = {m} и для n = {n} равен {result}");
// }


// int AckermannFunction(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return
//         AckermannFunction(m - 1, 1);
//     }
//     else
//     {
//         return
//         AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     }
// }
//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
{
    int[] array = { 10, 20, 30, 40, 50 };
    PrintArrayInReverseOrder(array, array.Length - 1);

    void PrintArrayInReverseOrder(int[] arr, int i)
    {
        if (i >= 0)
        {
            Console.Write(arr[i] + " ");
            PrintArrayInReverseOrder(arr, i - 1);

        }
    }
}

