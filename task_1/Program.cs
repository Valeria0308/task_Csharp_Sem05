// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Main()
{
int [] array = FIllArray (4, 100, 999);
PrintArray(array);
Count(array);
}

int[] FIllArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

void Count (int [] arrayNew)
{
int count = 0;
for (int i = 0; i < arrayNew.Length; i++)
{
    int number = arrayNew[i];
    if (number % 2 == 0)
    {
        count++;
    }
 }
 System.Console.WriteLine($"Количество четных чисел: {count}");
 }

Main();
