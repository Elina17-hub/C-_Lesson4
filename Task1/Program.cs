//Создать двухмерный массив с размером 3х5 сост. из целых чисел и вывести его на экран
int[,] matrix = new int[3, 5];

Random rnd = new Random();//заполним массив случайными числами от 0 до 10
for (int i = 0; i < matrix.GetLength(0); i++)
//проход по строкам двумерного массива GetL - позволяет выяснить количество строк
//или столбцов в одномерном массиве, и если (0) то запрвшивается количество строк
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    // второй цикл позволяет обращаться к элементам одномерного массива.
    //GetL(1)- запрашивает количество столбцов в массиве
    {
        matrix[i, j] = rnd.Next(1, 11);//обращаемся к элементу двухмерного массива
    }
}
for (int i = 0; i < matrix.GetLength(0); i++) // второй цикл делает тоже самое,как в одномерном массиве, но уже второй раз для двумерного массива

{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine(); //чтобы ввывести в виде таблицы, а непострочно
}
// Вывод на панель массив из 3х строк и 5ти столбцов

int[,] CreateMatrix(int rowCount, int columsCount) // Функция c числом строк и числом столбцов
 {
     int[,] matrix = new int[rowCount, columsCount];

     Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        for (int j = 0; j < matrix.GetLength(1); j++)

        {
             matrix[i, j] = rnd.Next(1, 11);
        }
     }
     return matrix;
 }

 void ShowMatrix(int[,] matrix)
 {
     for (int i = 0; i < matrix.GetLength(0); i++) 

    {
         for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
     }
}

int[,]matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);
