 
using System.Runtime.CompilerServices;
using System.Text;
 
public  class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
 
        // Build a sandbox area to save my files
        string root = Path.Combine(Path.GetTempPath(), "FileClassDemo");
        Console.WriteLine(root);
        Directory.CreateDirectory(root);
 
        // Define other file paths in this demo
        string sourcePath = Path.Combine(root, "sample.txt");
        string copyPath = Path.Combine(root, "sample_copy.txt");
        string movedPath = Path.Combine(root, "archive", "sample_moved.txt");
 
        CreateNewFile(sourcePath);
        WriteInFile(sourcePath);
        AppendMoreInformationToFile(sourcePath);
        ReadAllTextFromFile(sourcePath);
        DeleteTheFile(sourcePath);
    }
 
    static void DeleteTheFile(string path)
    {
        // Have an Are you sure stucture to your delete method
        Console.Write("Are you sure (y/n): ");
        string? answer = Console.ReadLine().ToLower().Trim();
 
        if (answer == "y")
        {
            // This deletes the file at path
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine($"Your file at {path} has been deleted!");
            }
        }
        else
        {
            Console.WriteLine("File not deleted.");
        }
    }
 
    static void CreateNewFile(string path)
    {
        Console.WriteLine($"Creating a new file at { path }");
 
        // Checking if file exists and if so, removes it
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine($"Your file at { path } has been deleted!");
        }
 
        using (File.Create(path)) { } ;
        Console.WriteLine($"File, { path } has been created.");
    }
 
    static void WriteInFile(string path)
    {
        string content = "Hello, World this will appear inside my file!\n";
        File.WriteAllText(path, content, Encoding.UTF8);
        Console.WriteLine($"""
            { content }
            Above information added to file
            { path }
            """);
    }
 
    static void AppendMoreInformationToFile(string path)
    {
        string multiLine = ("""
            This is line five
            This is line six
            """);
        File.AppendAllLines(path, new[] { "This is line one", "This is line two" }, Encoding.UTF8);
        File.AppendAllText(path, "This is line three \nThis is line four", Encoding.UTF8);
        File.AppendAllText(path, multiLine, Encoding.UTF8);
 
        Console.WriteLine($"""
            All text added to file { path }
            """);
    }
 
    static void ReadAllTextFromFile(string path)
    {
        // Read all the lines into an array
        string[] lines = File.ReadAllLines(path, Encoding.UTF8);
 
        Console.WriteLine($"Line count: {lines.Length}");
        Console.WriteLine($"Contents({path}): ");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
 
 
}