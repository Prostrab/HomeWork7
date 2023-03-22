
// Задача 2 
// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет



Console.Clear();
Random rnd = new Random();
int[,] Array = GetArray(6, 7, 1, 10);


int[,] GetArray(int row, int columns, int min, int max) //Задаем массив 
{

    int[,] Array = new int[row, columns];

    for (int i = 0; i < Array.GetLength(0); i++)
    {

        for (int j = 0; j < Array.GetLength(1); j++)

        {
            Array[i, j] = rnd.Next(min, max);

        }

    }
    return Array;
}



void PrintArray(int[,] array)
{

    {
        Console.WriteLine("Полученный массив : ");
        for (int i = 0; i < array.GetLength(0); i++)

        {
            for (int j = 0; j < array.GetLength(1); j++)

            {

                Console.Write(array[i, j] + "  ");

            }
            Console.WriteLine("   ");

        }
    }

}

PrintArray(Array);




void GetNumberArray(int[,] array)
{
    Console.WriteLine("Введите индекс rows :");
    int index1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс columns :");
    int index2 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < array.GetLength(0); i++)

    {
        for (int j = 0; j < array.GetLength(1); j++)
       
        {
            if (j == index1 && i == index2)
            
            {
                Console.WriteLine(array[i,j]);


            }
            

        }

    }
    if (index1 >= array.GetLength(0) && index2 >= array.GetLength(1))
            {
                Console.WriteLine("Индекс не входит в массив");
            }
}

GetNumberArray(Array);
