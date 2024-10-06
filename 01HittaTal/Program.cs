//Fyller en stringvariabel med en textsträng från användaren
Console.Write("Write a line of characters with either numbers or letters: ");
string input = Console.ReadLine();
Console.WriteLine(" ");

for (int i = 0; i < input.Length; i++)
{
    string subInput = input.Substring(i); //Substring av input som minskar i läng med varje loop
    string firstChar = subInput.Substring(0, 1); //Fylls med första värdet i subInput

    int searchRepeat = subInput.IndexOf(firstChar, 1); //Fylls med indexen av det första repeterade värdet av firstChar
    string matchingNumb = subInput.Substring(0, searchRepeat + 1); //Fylls med alla värden som står mellen repeterade värden

    bool onlyNumb = int.TryParse(matchingNumb, out searchRepeat); //Boolvariabel som tar reda på om värderna i matchingNumb är enbart nummer

    string[] splitInput = input.Split(matchingNumb); //Använder matcingNumb för att splitra input

    //Använder onlyNumb för att ignorera alla repetrande värden som innehåller bokstäver eller andra tecken
    if (onlyNumb == true)
    {
        Console.Write(splitInput[0]);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(matchingNumb);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(splitInput[1]);
    }
}

Console.WriteLine(" ");
Console.Write("Press random key to exit program...");
Console.ReadKey();