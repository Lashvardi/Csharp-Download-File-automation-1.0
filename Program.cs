using Installer;
int selectedOption = 1;

while (true)
{
    Console.Clear();

    if (selectedOption == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Node.JS");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Node.JS");
    }

    if (selectedOption == 2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Visual Studio Code");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Visual Studio Code");
    }

    if (selectedOption == 3)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Microsoft Visual Studio");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Microsoft Visual Studio");
    }

    Console.ForegroundColor = ConsoleColor.Gray;
    ConsoleKeyInfo pressedKey = Console.ReadKey();
    if (pressedKey.Key == ConsoleKey.UpArrow)
    {
        if (selectedOption > 1)
        {
            selectedOption--;
        }
    }
    else if (pressedKey.Key == ConsoleKey.DownArrow)
    {
        if (selectedOption < 3)
        {
            selectedOption++;
        }
    }
    if(selectedOption == 1)
    {
        var Option = "Node.js";

         if (pressedKey.Key == ConsoleKey.Enter)
        {
            Downloader.Download();
            Console.WriteLine($"\n {Option} Has Been Successfuly Installed ");
            break;
        }
    }

    if (selectedOption == 2)
    {
        string? gela = "Visual Studio Code";
        if (pressedKey.Key == ConsoleKey.Enter)
        {
            Console.WriteLine("\nYou selected Option " + gela);
            Console.ReadKey();
            break;
        }
    }

    if (selectedOption == 3)
    {
        string? gela = "Microsoft Visual Studio";

        if (pressedKey.Key == ConsoleKey.Enter)
        {
            Console.WriteLine("\nYou selected Option " + gela);
            Console.ReadKey();
            break;
        }
    }
}