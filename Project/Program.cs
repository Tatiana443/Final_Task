string[] array1 = { "hello", "2", "world", ";-)", "1234", "-2" };

void PrintArray(string[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        if (i < array1.Length - 1) Console.Write($"{array1[i]}, ");
        else Console.Write($"{array1[i]}");
    }
    Console.Write("]");
}

void PrintArrayThreeChar(string[] arrayNew)
{
    for (int i = 0; i < arrayNew.Length; i++)
    {
        Console.Write(arrayNew[i] + " ");
    }
}

string[] CreatNewArrayThreeChar(string[] array)
{
    string[] arrayNew = new string[array.Length];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[temp] = array[i];
            temp++;
        }
    }
    return arrayNew;
}

Console.WriteLine(" ");
PrintArray(array1);
Console.WriteLine($" --> ");
string[] arrayNew = CreatNewArrayThreeChar(array1);
PrintArrayThreeChar(arrayNew);

