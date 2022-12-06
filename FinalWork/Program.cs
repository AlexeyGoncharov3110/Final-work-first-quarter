Console.WriteLine("Введите размер массива");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedN)
{
    Console.WriteLine("Ошибка!Повторите ввод");
    return;
}

