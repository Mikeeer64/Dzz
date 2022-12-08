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

int namber = GetNamber("Введите число: ");
int sum = 0;
    
do
{
    sum = sum + namber % 10;
    namber = namber / 10;
}
while(namber > 0);

Console.WriteLine($"Сумма чисел = {sum}");
