
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
 количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int [] CreatRandomArray (int size) 
{
    int [] newArray = new int [size]; 
    for (int i = 0; i < size; i++)
    {
    newArray[i] = new Random().Next(1, 1001);
    }
    return newArray; 
}

void ShowArray (int [] arr)
{
    
    Console.Write("Массив -> ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+ " ");
    }
    Console.WriteLine();
}

void Find(int []array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++;

Console.WriteLine($"всего {array.Length} чисел, {count}  чётные");
}

Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int [] MyArray = CreatRandomArray(size);
ShowArray(MyArray);
Find(MyArray);
