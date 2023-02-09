using Installer;
int selectedOption = 1;
string option="";

while (true)
{
    Console.Clear();

    Console.ForegroundColor = selectedOption == 1 ? ConsoleColor.Green : ConsoleColor.Gray;
    Console.WriteLine("Node.JS");

    Console.ForegroundColor = selectedOption == 2 ? ConsoleColor.Green : ConsoleColor.Gray;
    Console.WriteLine("Visual Studio Code");

    Console.ForegroundColor = selectedOption == 3 ? ConsoleColor.Green : ConsoleColor.Gray;
    Console.WriteLine("Microsoft Visual Studio");

    Console.ForegroundColor = ConsoleColor.Gray;
    ConsoleKeyInfo pressedKey = Console.ReadKey();
    Press(pressedKey, ref selectedOption);

    if (pressedKey.Key == ConsoleKey.Enter)
    {
        switch (selectedOption)
        {
            case 1:
                option = "Node.js";
                Downloader.Download();
                break;
            case 2:
                option = "Visual Studio Code";
                break;
            case 3:
                option = "\"Microsoft Visual Studio\";";
                break;
        }
        Console.WriteLine($"\n {option} Has Been Successfuly Installed ");
        Console.ReadKey();
    }
}

void Press(ConsoleKeyInfo pressedKey, ref int selectedOption)
{
    if (pressedKey.Key == ConsoleKey.UpArrow)
        selectedOption--;
    else if (pressedKey.Key == ConsoleKey.DownArrow)
        selectedOption++;
    selectedOption = selectedOption < 1 ? 3 : selectedOption > 3 ? 1 : selectedOption;
}