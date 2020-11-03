using static System.Console;
using System.IO;
class DirectoryInformation
{
    static void Main()
    {
        string directoryName;
        string[] listOfFiles;
        //Write("Enter a folder >> ");
        //directoryName = ReadLine();
        directoryName = @"C:\Users\m2web\OneDrive\Documents\NKU\BIS 305\C#\Chapter 14\Lecture\ClientMemos";
        if (Directory.Exists(directoryName))
        {
            WriteLine("Directory exists, and it contains the following:");
            listOfFiles = Directory.GetFiles(directoryName);
            for (int x = 0; x < listOfFiles.Length; ++x)
                WriteLine("   {0}", listOfFiles[x]);
        }
        else
        {
            WriteLine("Directory does not exist");
        }
    }
}
