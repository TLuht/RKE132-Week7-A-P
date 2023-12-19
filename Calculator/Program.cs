Console.WriteLine("Enter the operation (+/-)");
char userOperator = char.Parse(Console.ReadLine());

Console.WriteLine("Enter number A");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter number B");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum); 
        break;
    case '-':
        Subtraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("Error with input");
        break;
}

static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}