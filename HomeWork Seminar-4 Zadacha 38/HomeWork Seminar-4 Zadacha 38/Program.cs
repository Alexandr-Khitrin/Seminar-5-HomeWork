Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());

double[] array = new double[size];
Random random = new Random();

void Array(double[] arr)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0:F2} | ", array[i]);
    }
    Console.WriteLine();
    
}


//double max(double[] arr)
//{
//    double maxV = array[0];
//    for (int i = 0; i < size; i++)
//    {
//        if (array[i] > maxV)
//        {
//            maxV = array[i];
//        }
//    }
//    return maxV;
//}

//double min(double[] arr)
//{
//    double minV = array[0];
//    for (int i = 0; i < size; i++)
//    {
//        if (array[i] < minV)
//        {
//            minV = array[i];
//        }
//    }
//    return minV;
//}

double diff(double[] arr)
{
    double differ = 0;
    for (int i = 0; i < size; i ++)
    {
        differ = arr.Max() - arr.Min();
    }
    return differ;
}

Array(array);
//Console.Write("Максимальный элемент массива: ");
//Console.Write(max(array));
//Console.WriteLine();
//Console.Write("Минимальный элемент массива: ");
//Console.Write(min(array));
//Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементом массива: ");
Console.Write(diff(array));
Console.WriteLine();

