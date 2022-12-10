
int size = 200;


int[] FillArray(int arr)

{
    int[] array = new int[arr];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}


void ResultArray(int[] array)
{
    int countEven = 0;
    int countOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
        if (array[i] % 2 == 0) countEven++;
        else countOdd++;
    }
    Console.WriteLine();
    Console.WriteLine($"Четных: {countEven}. Нечетных: {countOdd}");
}   

ResultArray(FillArray(size));







