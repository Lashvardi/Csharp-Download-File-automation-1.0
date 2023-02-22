using Installer;

Console.Title = "DownloadEZ";

int selectedOption = 1;
string option = "";
List<string> urls = new List<string>()
    {
        "https://nodejs.org/dist/v18.14.0/node-v18.14.0-x64.msi",
        "https://code.visualstudio.com/sha/download?build=stable&os=win32-x64-user",
        "https://aka.ms/vs/17/release/vs_community.exe",
        "https://byrut.org/index.php?do=download&id=83260",
        "https://www.fileour.com/download/adobe-after-effects-cc-17-5-1-free-download/?wpdmdl=9765&refresh=63f5013e09afb1677001022"
    };

while (true)
{
    Console.Clear();

    Console.WriteLine($"Number Of Apps Available {urls.Count()}");
    Console.WriteLine();
    Console.ForegroundColor = selectedOption == 1 ? ConsoleColor.Green : ConsoleColor.Gray;
    Console.WriteLine("Node.JS");

    Console.ForegroundColor = selectedOption == 2 ? ConsoleColor.Green : ConsoleColor.Gray;
    Console.WriteLine("Visual Studio Code");

    Console.ForegroundColor = selectedOption == 3 ? ConsoleColor.Green : ConsoleColor.Gray;
    Console.WriteLine("Microsoft Visual Studio");

    Console.ForegroundColor = selectedOption == 4 ? ConsoleColor.Green : ConsoleColor.Gray;
    Console.WriteLine("Adobe Photoshop 2022");

    Console.ForegroundColor = selectedOption == 5 ? ConsoleColor.Green : ConsoleColor.Gray;
    Console.WriteLine("Adobe After Effects 2021");


    Console.ForegroundColor = ConsoleColor.Gray;
    ConsoleKeyInfo pressedKey = Console.ReadKey();
    Press(pressedKey, ref selectedOption);

    if (pressedKey.Key == ConsoleKey.Enter)
    {
        switch (selectedOption)
        {
            case 1:
                option = "Node.js";
                Downloader.DownloadNode(urls.ElementAt(0), "node-v18.14.0-x64.msi");
                break;
            case 2:
                option = "Visual Studio Code";
                Downloader.DownloadNode(urls.ElementAt(1), "VisualStudioCodeInstaller.exe");
                break;
            case 3:
                option = "\"Microsoft Visual Studio\";";
                Downloader.DownloadNode(urls.ElementAt(2), "VisualStudioInstaller.exe");
                break;
            case 4:
                option = "\"Photoshop 2022\";";
                Downloader.DownloadNode(urls.ElementAt(3), "Adobe-Photoshop-2022(RePack-by-KpoJIuK).torrent");
                break;
            case 5:
                option = "\"Adobe After Effects 2021\";";
                Downloader.DownloadNode(urls.ElementAt(4), "Adobe After Effects 2021.zip");
                break;
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "Download Completed 100%";
        Console.WriteLine($"\n {option} Has Been Successfuly Installed ");
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
    }
}

void Press(ConsoleKeyInfo pressedKey, ref int selectedOption)
{
    /// Added URL Count
    if (pressedKey.Key == ConsoleKey.UpArrow)
        selectedOption--;
    else if (pressedKey.Key == ConsoleKey.DownArrow)
        selectedOption++;
    selectedOption = selectedOption < 1 ? urls.Count() : selectedOption > urls.Count() ? 1 : selectedOption;
}