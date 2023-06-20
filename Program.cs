// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.


// Console.WriteLine("Введите количество строчек");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество колонок");
// int columns = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [rows,columns];


// void GetArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]=new Random().Next(0,10);
//         }
//     }
// }


//  void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]);
//         }
//         Console.WriteLine();
//     }
// }
// void ChangeArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int x = 0; x < array.GetLength(1)-1; x++)
//             {
//                 if(array[i,x]<array[i,x+1])
//                 {
//                     int temp=array[i,x+1];
//                     array[i,x+1]=array[i,x];
//                     array[i,x]=temp;
//                 }
//             }
//         }
//     }
// }
// GetArray();
// PrintArray();
// Console.WriteLine();
// ChangeArray();
// PrintArray();


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int [,,] array = new int [2,2,2];


// void GetArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i,j,k]=new Random().Next(0,10);
//             }
            
//         }
//     }
// }


//  void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//          for (int k = 0; k < array.GetLength(2); k++)
//          {
//             Console.Write(array[i,j,k]);
//          }
            
//         }
//         Console.WriteLine();
//     }
// }
// GetArray();
// PrintArray();



