using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string path = "file.txt";
        FileManager fileManager = new FileManager(path);
        fileManager.WriteToFile(path);
        fileManager.ReadFromFile();
        Console.WriteLine(fileManager.ReadFromFile);

    }
}

public class FileManager : IDisposable
{

    StreamWriter _stream;
    public FileManager(string path)
    {
        _stream = new StreamWriter(path);
    }
    public void WriteToFile(string filePath)
    {

        using (FileStream fs = File.Create(filePath))
        {
            _stream.WriteLine(filePath);
            _stream.Flush();
        }
    }
    public void Dispose()
    {
        _stream.Close();
    }
    bool _disposed;
    protected void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _stream.Dispose();
            }
        }
        _disposed = true;
    }
    public void ReadFromFile()
    {
        using (FileStream fs = File.OpenRead(_stream.ToString()))
        {
            byte[] buffer = new byte[1024];
            UTF8Encoding uTF8 = new UTF8Encoding(true);
            int readLen;
            while ((readLen = fs.Read(buffer, 0, buffer.Length)) > 0)
            {
                Console.WriteLine(uTF8.GetString(buffer, 0, readLen));
            }
        }
    }
    private static void AddText(FileStream fs, string value)
    {
        byte[] bytes = new UTF8Encoding(true).GetBytes(value);
        fs.Write(bytes, 0, bytes.Length);
    }
}