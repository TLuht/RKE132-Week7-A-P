Console.WriteLine("Convert temperature to Celsius or Fahrenheit? (C/F)");
char userChoice = char.ToUpper(char.Parse(Console.ReadLine()));

Console.WriteLine("Insert temperature");
int userInput = Int32.Parse(Console.ReadLine());

switch(userChoice)
{
    case 'C':
        ConvertToCelsius(userInput);
        break;
    case 'F':
        ConvertToFahrenheit(userInput);
        break;
    default:
        Console.WriteLine("Error, wrong conversion unit selected");
        break;
}

static void ConvertToCelsius(int userInput)
{
    Console.WriteLine($"{(userInput - 32) * 5 / 9} kraadi ");
}

static void ConvertToFahrenheit(int userInput)
{
    Console.WriteLine($"{(userInput * 9) / 5 + 32} kraadi");
}