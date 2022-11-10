
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int SetNumber(string str)
{
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[,] GetRandomMatrix(int rows, int columns, int maxVal = 100, int minVal = -100)
{
double[,] matrix = new double[rows, columns];
var random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = random.Next(minVal, maxVal+1);
    }
}
return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)  
  {
    Console.Write(matrix[i,j] + " ");
  }
  Console.WriteLine(); 
}
}

int rows = SetNumber("Введите m");
int columns = SetNumber("Введите n");
double[,] matrix = GetRandomMatrix(rows, columns, 10, -12);
PrintMatrix(matrix);
Console.WriteLine();


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


int SetNumber(string str)
{
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetRandomMatrix(int rows, int columns, int maxVal = 100, int minVal = -100)
{
int[,] matrix = new int[rows, columns];
var random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = random.Next(minVal, maxVal+1);
    }
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)  
  {
    Console.Write(matrix[i,j] + " ");
  }
  Console.WriteLine(); 
}
}

int rows = SetNumber("Введите m");
int columns = SetNumber("Введите n");
int[,] matrix = GetRandomMatrix(rows, columns, 10, 0);
PrintMatrix(matrix);
Console.WriteLine();

System.Console.WriteLine("введите число для проверки");
int num2 = int.Parse(Console.ReadLine());

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(matrix[i,j] == num2 )
        {
System.Console.WriteLine($"введенное число равно числу под индексами {i} {j}");
        }
    if(matrix[i,j] != num2)
    {
System.Console.WriteLine("данное число не равно заданному");
}
    }
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int SetNumber(string str)
{
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[,] GetRandomMatrix(int rows, int columns, int maxVal = 100, int minVal = -100)
{
double[,] matrix = new double[rows, columns];
var random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = random.Next(minVal, maxVal+1);
    }
}
return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)  
  {
    Console.Write(matrix[i,j] + " ");
  }
  Console.WriteLine(); 
}
}

int rows = SetNumber("Введите m");
int columns = SetNumber("Введите n");
double[,] matrix = GetRandomMatrix(rows, columns, 10 , 0 );
PrintMatrix(matrix);
Console.WriteLine();


Console.WriteLine("Матрица");
int M = matrix.GetLength(1);
      double[] summ = new double[M];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                  
                    Console.Write(matrix[i, j]); 
                    summ[i] += matrix[j, i];    
                } 
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (double elem in summ)
            {
                
                Console.WriteLine(elem/M); 

