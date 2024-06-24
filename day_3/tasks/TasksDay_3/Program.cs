using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string path = "file.txt";
        FileManager fileManager = new FileManager(path);
        fileManager.WriteToFile("test");
        string read = fileManager.ReadFromFile();
        Console.WriteLine(read);
    }
}

public class FileManager
{

    private string _filePath;
    public FileManager(string path)
    {
        _filePath = path;
    }
    public void WriteToFile(string filePath)
    {

        using (FileStream fs = new FileStream(_filePath, FileMode.Create, FileAccess.Write))
        {
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(filePath);
            }
        }
    }

    public string ReadFromFile()
    {
        using (FileStream fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader reader = new StreamReader(fs))
            {
                return reader.ReadToEnd();
            }
        }
    }
    private static void AddText(FileStream fs, string value)
    {
        byte[] bytes = new UTF8Encoding(true).GetBytes(value);
        fs.Write(bytes, 0, bytes.Length);
    }

}