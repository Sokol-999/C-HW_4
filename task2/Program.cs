// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int InputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();

        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("ERROR, try again");
    }
    return number;

}

int A = InputNumber("Write number: ");
string str = A.ToString();
int length = str.Length;
int sum = 0;
for (int i = 0; i < length; i++)
{
    sum = sum + (str[i] - '0');
}
System.Console.WriteLine($"Sum of digits: {sum} ");


