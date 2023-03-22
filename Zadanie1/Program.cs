// Задача1 
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Random rnd = new Random();
float [,] array = GetArray(4,4,-10,10);

float [,] GetArray(int row, int columns, int min, int max)
{

    float[,] Array = new float[row, columns];

    for (int i = 0; i < Array.GetLength(0); i++)
    {

        for (int j = 0; j < Array.GetLength(1); j++)

        {
            Array[i, j] = rnd.Next(min,max);

        }


    }
    return Array;
}


void PrintArray (float [,] array)
{

{
    for (int i = 0; i < array.GetLength(0); i++)

    {
        for (int j = 0; j < array.GetLength(1); j++)

        {

            Console.Write(array[i,j] + "  ");

        }
        Console.WriteLine("   ");

    }
}

}

 PrintArray (array);



