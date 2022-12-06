Console.WriteLine("Введите размер массива");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedN)
{
    Console.WriteLine("Ошибка!Повторите ввод");
    return;
}
string[] stringArray = StringArray(n);
int numberOfLines = NumberOfLines(stringArray);
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
