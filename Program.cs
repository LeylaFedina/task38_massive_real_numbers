/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
int [] getRandomArray (int length, int startPoint, int endPoint)
{
    int [] resultArray = new int [length];
    for (int i = 0; i < length; i ++)
    {
        resultArray [i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray (int [] incommingArray)
{
    Console.Write("[");
    for (int i = 0; i < incommingArray.Length; i++)
    {
        Console.Write(incommingArray [i]);
        if (i < incommingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine ("]");
}
int getMaxNumbersInArray (int [] incommingArray)
{
    int result = 0;
    int max = incommingArray[0];
    for (int i = 0; i < incommingArray.Length; i++)
    {
        if (incommingArray[i] > max)
        {
            max = incommingArray [i];
        }
    }
    return result;
}
int getMinNumbersInArray (int [] incommingArray)
{
    int result = 0;
    int min = incommingArray[0];
    for (int i = 0; i < incommingArray.Length; i++)
    {
        if (incommingArray[i] < min)
        {
            min = incommingArray [i];
        }
    }
    return result;
}
int [] currentArray = getRandomArray(12,-5,5);
printArray (currentArray);
int MaxNumber = getMaxNumbersInArray (currentArray);
int minNumber = getMinNumbersInArray (currentArray);
Console.WriteLine($"разница между максимальным и минимальным значением в массиве равна {MaxNumber - minNumber}");
