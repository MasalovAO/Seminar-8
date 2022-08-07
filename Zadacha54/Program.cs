//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8

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

void SortArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < inArray.GetLength(1) - 1; z++)
            {
                if(inArray[i,z] < inArray[i,z+1])
                {
                    int k = inArray[i,z];
                    inArray[i,z] = inArray[i,z+1];
                    inArray[i,z+1] = k;
                }
                
            }
    
        }
               
    }
}


int [,] Ar = Fillarr(m,n);
printArray(Ar); 
SortArray(Ar);
Console.WriteLine();
printArray(Ar);