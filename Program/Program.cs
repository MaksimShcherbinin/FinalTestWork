string[] FillFirstArray(ref int count)
{
    Console.Write("Введите кол-во элементов массива: ");
    int size = Convert.ToInt16(Console.ReadLine());
    string[] firstArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите {0} элемент массива: ", i + 1);
        firstArray[i] = Console.ReadLine();
        if (firstArray[i].Length <= 3)
            count++;
    }
    return firstArray;
}

string[] FillSecondArray(string[] firstArray, int count)
{
    string[] secondArray = new string[count];
    for (int j = 0; j < firstArray.Length; j++)
    {
        if (firstArray[j].Length <= 3)
        {
            secondArray[^count] = firstArray[j];
            count--;
        }
    }
    return secondArray;
}

int count = 0;
string[] array = FillFirstArray(ref count);
Console.WriteLine("Начальный массив: [" + string.Join(",", array) + "]");
array = FillSecondArray(array, count);
Console.WriteLine("Конечный массив: [" + string.Join(",", array) + "]");
