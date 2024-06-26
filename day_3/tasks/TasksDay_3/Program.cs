using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string path = "file.txt";
        Method1(path);
        Method1(path);

    }
    static void Method1(string path)
    {
        FileManager fileManager = new FileManager(path);
        fileManager.WriteToFile("test");
    }
}

public class FileManager : IDisposable
{

    FileStream stream;

    public FileManager(string path)
    {
        stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
    }
    public void WriteToFile(string filePath)
    {
        AddText(stream, filePath);
    }
    public void Dispose()
    {
        Dispose(true);
    }
    bool _disposed;
    protected void Dispose(bool disposing)
    {
        if (_disposed) return;
        if (disposing)
        {
            stream.Close();
        }
        _disposed = true;
    }
    public void ReadFromFile()
    {
        byte[] buffer = new byte[1024];
        UTF8Encoding uTF8 = new UTF8Encoding(true);
        int readLen;
        while ((readLen = stream.Read(buffer, 0, buffer.Length)) > 0)
        {
            Console.WriteLine(uTF8.GetString(buffer, 0, readLen));
        }
    }
    private static void AddText(FileStream fs, string value)
    {
        byte[] bytes = new UTF8Encoding(true).GetBytes(value);
        fs.Write(bytes, 0, bytes.Length);
    }
    ~FileManager()
    {
        Dispose(false);
    }
}