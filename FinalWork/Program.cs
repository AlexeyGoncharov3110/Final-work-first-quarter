Console.WriteLine("Введите размер массива");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedN)
{
    Console.WriteLine("Ошибка!Повторите ввод");
    return;
}
string[] stringArray = StringArray(n);
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
