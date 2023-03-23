




string[] CheckAlgo(string[] array, int value, int length = 0)
{
    string[] defArray = new string[length];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= value)
        {
            if (defArray.Length > 0 && j < defArray.Length)
            {
                defArray[j] = array[i];
                j++;
            }
            length++;
        }
    }

    if (length > 0 && defArray.Length <= 0) return CheckAlgo(array, value, length);
    return defArray;
}

string Show(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? String.Empty;
}

string[] CreateArray(int lenght)
{
    string[] arr = new string[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Show($"Введите любое значение в  {i}  элемент массива");
    }
    return arr;
}

int lenght = Convert.ToInt32(Show("Введите длину массива"));

int value = Convert.ToInt32(Show("Введите необходимую длину элементов массива  "));

string[] arr = CreateArray(lenght);

Console.Write($"[{string.Join(", ", arr)}] -> [{string.Join(" , ", CheckAlgo(arr, value))}]");