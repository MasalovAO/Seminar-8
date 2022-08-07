//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = 3;
int n = 4;


int[,] Fillarr (int mNum, int nNum)
{
    int [,] result = new int [mNum,nNum];
    for (int i = 0; i < mNum; i++)
    {
        for ( int j = 0; j < nNum; j++)
        {
            result [i,j] = new Random().Next(0,10);
        }
    }
    return result;

}

void printArray (int [,] arr )
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for ( int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}");
        }
        Console.WriteLine("");
    }
}

void sumString (int[,] inArray)
{
    int line = 0;
    int minSum = Int32.MaxValue;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {   
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
           sum = sum + inArray[i,j]; 
        }
        
        if (minSum > sum)
        {
            minSum = sum;
            line++;
        }
   
    }
    Console.WriteLine($"Cтрока с наименьшей суммой {line}");   

}

int [,] Ar = Fillarr(m,n);
printArray(Ar);
sumString(Ar);

