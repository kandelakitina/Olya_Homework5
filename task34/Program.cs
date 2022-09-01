// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Создаем функцию по созданию массива чисел

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random ();
    for (int i = 0; i <size; i++)
    {
        array [i] = rnd.Next(min, max +1);
    }
return array;
}

// Вызываем функцию с нужным параметрами
// и записываем результат (массив из 4х чисел)
// в переменную "arr1"

int [] arr1 = CreateArrayRndInt (4, 100, 999);

// Создаем функцию, считающую количество четных
// чисел в массиве

int FindEvenNumber (int[]array)
{
    int count = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

// Вызываем функцию и скармливаем ей перечень, а результат
// записываем в переменную resultArr

int resultArr = FindEvenNumber(arr1);

void PrintArray (int[]array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write(array[i]+ ",");
    }
    Console.Write(array[array.Length]);
    Console.Write("]");
}

PrintArray(arr1);
Console.Write(resultArr);
