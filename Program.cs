//using System;
//using System.Net;
//using System.Threading;
//using System.Web;
//namespace ConsoleApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string url = "https://nodejs.org/dist/v18.14.0/node-v18.14.0-x64.msi";
//            string directory = "C:/Users/HP/Desktop/c#_testtt";

//            Uri uri = new Uri(url);
//            string filename = System.IO.Path.GetFileName(uri.LocalPath);

//            using (var client = new WebClient())
//            {
//                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
//                client.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(DownloadCompleted);
//                client.DownloadFileAsync(new Uri(url), directory + "\\" + filename);
//                Console.WriteLine("Downloading...");

//                while (client.IsBusy)
//                {
//                    Thread.Sleep(100);
//                }
//            }
//        }

//        private static object _lock = new object();
//        private static void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
//        {
//            lock (_lock)
//            {
//                Console.Write("\r{0}% complete.", e.ProgressPercentage);
//                Console.Write("[");
//                int progress = e.ProgressPercentage / 2;
//                for (int i = 0; i < progress; i++)
//                {
//                    Console.ForegroundColor= ConsoleColor.Blue;
//                    Console.Write("#");
//                    Console.ForegroundColor = ConsoleColor.White;

//                }
//                for (int i = 0; i < 50 - progress; i++)
//                {
//                    Console.Write(" ");
//                }
//                Console.Write("]");
//            }
//        }

//        private static void DownloadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
//        {
//            Console.ForegroundColor= ConsoleColor.Green;
//            Console.WriteLine("\nDownload completed!");
//            Console.WriteLine();
//        }
//    }
//}

using System;

            int selectedOption = 1;

while (true)
{
    Console.Clear();

    if (selectedOption == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Option 1");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Option 1");
    }

    if (selectedOption == 2)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Option 2");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Option 2");
    }

    if (selectedOption == 3)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Option 3");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Option 3");
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
    else if (pressedKey.Key == ConsoleKey.Enter)
    {
        Console.WriteLine("\nYou selected Option " + selectedOption);
        Console.ReadKey();
        break;
    }
}