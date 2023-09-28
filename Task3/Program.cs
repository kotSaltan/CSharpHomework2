// программа принимает цифру (день недели) и проверяет на выходной

int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekday (int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Wring number format");
    return false;
}
int weekDay = Prompt ("Enter weekday number: ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Weekend");
    }
    else
    {
        Console.WriteLine("Weekday");
    }
}