// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] arr1 = CreateArrayRndInt (4, 0, 999);
int [] resultArr = FindEvenNumber(arr1);
PrintArray (arr1);
PrintArray (resultArr);


int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int [size];
    Random rnd = new Random ();

    for (int i = 0; i <size; i++)
{
    array [i] = rnd.Next(min, max +1);
}
return array;
}

void PrintArray (int[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write(array[i]+ ",");
    }
    Console.Write(array[array.Length -1]);
    Console.Write("]");
}
// int[] CalcArr(int [] arr)
// {
//     int size = arr.Length/2;
//     if (int % 2 != 0) count++;
    
//     int[] resArr = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         resArr [i] = arr[i]*arr [arr.Length -1 -i];
//     }
//     if (arr.Length %2 !=0) {resArr[resArr.Length -1] = arr[size];}   
//     return resArr;
// }
int [] FindEvenNumber (int [] arr)
{
count = 0
if (int % 2 != 0) count++;
}
for (int i = 0; i< array.Length; i++)
    {
        if (array[i] == int%2 ==0) count++;
        