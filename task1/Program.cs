// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

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

int numA = InputNumber($"Write first number: ");
int numB = InputNumber($"Write second number: ");

int res = 1;
if (numB == 0)
{
    System.Console.WriteLine($"Result: {res}");
}
else
{
    res = numA;
    for (int i = 1; i < numB; i++)
    {
        res = res * numA;
    }
    System.Console.WriteLine($"Result: {res}");
}



