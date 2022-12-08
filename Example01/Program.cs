int GetNamber(string message)
{
    int count = 0;
    bool isCorrect = false;
    while(!isCorrect)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out count)) isCorrect = true;
        else Console.WriteLine("Ввели не число");
    }
    return count;
}

int GetDegree(int namber1, int namber2)
{
    int result = namber1;
    for (int i = 0; i <= namber2; i++)
    {
        result = result * namber1;
    }
    return result;
}

int namber1 = GetNamber("Введите первое число: ");
int namber2 = GetNamber("Введите второе число: ");

Console.WriteLine(GetDegree(namber1, namber1));
