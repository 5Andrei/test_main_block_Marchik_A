string[] Request(string msg)
{
    Console.Write(msg);
    return Console.ReadLine().Split("; ");
}
string[] GetArrLessOrEqualThreeSymbols(string[] arr)
{
    int count = 0;
    string[] fresh = new string[count];
    string[] main = fresh;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) 
        {
            count++;
            fresh = new string[count];
            for (int j = 0; j < fresh.Length - 1; j++) 
            {
                fresh[j] = main[j];
            }
            fresh[count - 1] = arr[i];
            main = fresh;
        }
    }
    return main;
}
void PrintArr(string[] arr)
{   
    Console.Write($"[{String.Join("; ", arr)}]");
}
string[] arrOfStrings = Request("Введите элементы массива строк, отделяя каждый элемент массива точкой с запятой и пробелом (; ): ");
string[] arrOfThreeSymbols = GetArrLessOrEqualThreeSymbols(arrOfStrings);
Console.Write("Сформированный массив из элементов введенного массива ");
PrintArr(arrOfStrings);
Console.Write(", длинна которых меньше или равна 3 символам, равен ");
PrintArr(arrOfThreeSymbols);