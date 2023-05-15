// See https://aka.ms/new-console-template for more information
using TextToMorseCodeConverter;

var converter = new Converter();

Console.WriteLine(GameArt.GetLogo());
Console.WriteLine("Welcome!");
Console.WriteLine("Note: This converter uses the ITU standard. A '*' means the charater is not part of the standard.");
Console.WriteLine();

var gameIsOn = true;
while (gameIsOn)
{
    Console.WriteLine("Enter phrase to convert it to Morse Code or -1 to end the program:");
    string? input = Console.ReadLine();
    if (input == "-1")
        gameIsOn = false;
    else
    {
        var textConverted = converter.Convert(input?.ToUpper() ?? "");
        Console.WriteLine(textConverted);
    }
}
