// Задача 3 
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




Random rnd = new Random();
int [,] Array = GetArray(4,4,1,5); 
int[,] GetArray(int row, int columns, int min, int max)   //Задаем массив 
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



void GetSumIndexColomnsArr (int [,] array)

{
    float sum0 = 0;
    float sum1 = 0;
    float sum2 = 0;
    float sum3 = 0;
    
  for (int i = 0; i < array.GetLength(0); i++)

        {
            for (int j = 0; j < array.GetLength(1); j++)
            
            {
                if (j==0)

                {
                    sum0 = sum0 + array[i,j];


                }
                if (j==1)

                {
                    sum1 = sum1 + array[i,j];


                }
                if (j==2)

                {
                    sum2 = sum2 + array[i,j];


                }
                if (j==3)

                {
                    sum3 = sum3 + array[i,j];


                }
            }





  
}
  Console.WriteLine($"Ср.Арифметическое : 1 столбец = {sum0/array.GetLength(0)}; Второй столбец = {sum1/array.GetLength(0)};Третий столбец = {sum2/array.GetLength(0)};Четвертый столбец = {sum3/array.GetLength(0)} ");
}

GetSumIndexColomnsArr (Array);