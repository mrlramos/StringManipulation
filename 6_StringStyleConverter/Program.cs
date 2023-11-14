// See https://aka.ms/new-console-template for more information

Console.WriteLine("Text something:");
string? userInput = Console.ReadLine();

while (string.IsNullOrEmpty(userInput))
{
    Console.WriteLine("Text a valid sentence");
    userInput = Console.ReadLine();
}

userInput = ClearString(userInput);

Console.WriteLine(ConverterCamelCase(userInput));
Console.WriteLine(ConverterPascal(userInput));
Console.WriteLine(ConverterSnakeCase(userInput));
Console.WriteLine(ConverterKebabCase(userInput));
Console.WriteLine(ConverterUpperCase(userInput));
Console.WriteLine(ConverterLowerCase(userInput));
Console.WriteLine(StringInverter(userInput));

static string ClearString(string userInput)
{
    string userInputClean = string.Empty;

    for (int i = 0; i < userInput.Length; i++)
    {
        if (char.IsLetter(userInput[i]))
        {
            userInputClean.Append(userInput[i]);
        }
    }

    return userInputClean;
}

static string ConverterCamelCase(string userInput)
{

    return userInput;
}

static string ConverterPascal(string userInput)
{
    return userInput;
}

static string ConverterSnakeCase(string userInput)
{
    return userInput;
}

static string ConverterKebabCase(string userInput)
{
    return userInput;
}

static string ConverterUpperCase(string userInput)
{

    return userInput;
}

static string ConverterLowerCase(string userInput)
{
    return userInput;
}

static string StringInverter(string userInput)
{
    return userInput;
}

