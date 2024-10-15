
using System;
using System.IO;

class FileManager
{
    private string currentDir;

    public FileManager()
    {
        currentDir = Directory.GetCurrentDirectory();
    }

    public void Dirs()
    {
        string[] dirs = Directory.GetDirectories(currentDir);
        foreach (string dir in dirs)
        {
            Console.WriteLine(Path.GetFileName(dir));
        }
    }

    public void Files()
    {
        string[] files = Directory.GetFiles(currentDir);
        foreach (string file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }

    public void Back()
    {
        if (Directory.GetParent(currentDir) != null)
        {
            currentDir = Directory.GetParent(currentDir).FullName;
        }
        else
        {
            Console.WriteLine("Cannot move back");
        }
    }

    public void Cd(string dirName)
    {
        string newDir = Path.Combine(currentDir, dirName);
        if (Directory.Exists(newDir))
        {
            currentDir = newDir;
        }
        else
        {
            Console.WriteLine("Directory does not exist");
        }
    }

    public void PrintCurrentDir()
    {
        Console.WriteLine("Current directory: " + currentDir);
    }
}