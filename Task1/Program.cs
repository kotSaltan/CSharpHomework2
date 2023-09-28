// Программа принимает трехзначное число и показывает вторую цифру этого числа на выходе

int Prompt(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt ("Enter 3-digit number ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine ("Wrong number format");
    return;
}
Console.WriteLine($"entered number '{number}'");
int secondDigit = number / 10 % 10;
Console.WriteLine($"second digit is '{secondDigit}'");
