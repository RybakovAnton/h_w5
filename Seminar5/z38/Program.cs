// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Например
// [3,7,22,2,78] -> 76

int arrayLength = 5;

double[] array = new double[arrayLength];

double max = 0;
double min = 1000;   //Так и не смог толком разобраться как записать в эту переменную определенный элемент массива

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble (new Random().Next(100, 1000)) / 100;
    Console.Write(array[i]+" ");
}   
for (int i = 0; i < array.Length; i++)
{
    if(array[i]>max)
    {
        max = array[i];
    }
    if (array[i]<min)
    {
        min = array[i];
    }
    
}
System.Console.WriteLine();

System.Console.WriteLine("Максмальное число: "+ max + "  Минимальное число: "+ min);
System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {max - min}");