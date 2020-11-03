using static System.Console;
using System.IO;
class FileStatistics
{
    static void Main()
    {
        string fileName;
        //Write("Enter a filename >> ");
        //fileName = ReadLine();
        fileName = @"C:\Users\m2web\OneDrive\Documents\NKU\BIS 305\C#\Chapter 14\Lecture\BusinessLetter.txt";
        if (File.Exists(fileName))
        {
            WriteLine("File exists");
            WriteLine("File was created " +
               File.GetCreationTime(fileName));
            WriteLine("File was last written to " +
               File.GetLastWriteTime(fileName));
        }
        else
        {
            WriteLine("File does not exist");
        }
    }
}
