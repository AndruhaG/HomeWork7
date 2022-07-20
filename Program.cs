//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами, округлёнными до одного знака.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


void Zadacha47()
{
    Random random = new Random();
    Console.WriteLine("введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    double[,] array = new double[rows, columns];
    FillArray(array);
    PrintArray(array, rows, columns);
    Console.WriteLine();

    void FillArray(double[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = new Random().NextDouble() * 20 - 10;
            }
        }
    }

    void PrintArray(double[,] array, int rows, int columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(Math.Round(array[i, j], 1) + "\t");
            }
            Console.WriteLine();
        }
    }
}



//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


void Zadacha50()
{
    int startNumbers = 1;
    int finishNumbers = 100;
    Random random = new Random();
    int rows = random.Next(1,10);
    int columns = random.Next(1,10);

    Console.WriteLine("введите номер строки вашего элемента");
    int rowNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите номер столбца вашего элемента");
    int columnNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array, rows, columns);
    Console.WriteLine();
    CheckingTheNumber ();
    Console.WriteLine();

    void FillArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = new Random().Next(startNumbers, finishNumbers);
            }
        }
    }

    void PrintArray(int[,] array, int rows, int columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    
    void CheckingTheNumber ()
    {
        if (1 <= rowNumber && rowNumber <= rows && 1 <= columnNumber && columnNumber <= columns)
        {
            Console.WriteLine($"Ваш элемент { array[rowNumber, columnNumber]} ");
        }
        else
         Console.WriteLine("элемента не существует ");
    }   
}


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6;



void Zadacha52()
{
    int startNumbers = 1;
    int finishNumbers = 100;
    Random random = new Random();
    Console.WriteLine("введите количество строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array, rows, columns);
    Console.WriteLine();
    sumArithmeticMeanInColumns ();
    Console.WriteLine();

    void FillArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = new Random().Next(startNumbers, finishNumbers);
            }
        }
    }

    void PrintArray(int[,] array, int rows, int columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    void sumArithmeticMeanInColumns ()
    {
        for (int j = 0; j < rows; j++)
        {
            double sum = 0;
            for (int i = 0; i < columns; i++)
            {
                sum += array[i, j];
                
            }
            
            double arithmeticMean = sum/rows;
            Console.Write(arithmeticMean + "\t");
        }
    }   
}






//Zadacha47();
//Zadacha50();
Zadacha52();




