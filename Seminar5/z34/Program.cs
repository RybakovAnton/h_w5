// Задача 34: Задайте массив заполненный случайнымии положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Например:
// [345, 897, 568, 234] -> 2


int arrayLength = 5;
int countNumber = 0;

int[] array = new int[arrayLength];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    System.Console.Write(array[i]+" ");
    
    if (array[i]%2==0)
    {
        countNumber+=1;
    }
}

System.Console.WriteLine("Кол-во четных чисел: "+ countNumber);