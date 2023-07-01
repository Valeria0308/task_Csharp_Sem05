// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Main()
{
    int[] array = FIllArray(4, -100, 100);
    PrintArray(array);
    SelectionSort(array);
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

void SelectionSort(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        int position = array[i];
        if (i % 2 == 1)
        {
            sum += position;
            i++;
        }
    }
    System.Console.WriteLine(sum);
}

Main();
