
int size = 20;

int[] array = new int[size];

void PrintArray(int[] arr)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

void FillArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}

void SummArray(int[] sum)
{
    int arraySum = 0;
    
    for (int i = 1; i < array.Length; i += 2)
    {
        arraySum = arraySum + array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов на нечетных позициях: {arraySum}");  
}


FillArray(array);
PrintArray(array);
SummArray(array);
