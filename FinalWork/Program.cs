Console.WriteLine("Введите размер массива");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedN)
{
    Console.WriteLine("Ошибка!Повторите ввод");
    return;
}
string[] stringArray = StringArray(n);
int numberOfLines = NumberOfLines(stringArray);
string[] arrayLessThanFourCharacters = ArrayLessThanFourCharacters(stringArray, numberOfLines);
PrintArray(arrayLessThanFourCharacters);
string[] ArrayLessThanFourCharacters(string[] str, int size)
{
    string[] finalArray = new string[size];
    int i = 0;
    int j = 0;
    while (i < str.Length)
    {
        if (str[i].Length <= 3)
        {
            finalArray[j] = str[i];
            j++;
        }
        i++;
    }
    return finalArray;
}
int NumberOfLines(string[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
            count++;
    }
    return count;
}
string[] StringArray(int n)
{
    string[] array = new string[n];
    Console.WriteLine("Введите строки массива");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ,");
    }
    Console.Write("]");
}
