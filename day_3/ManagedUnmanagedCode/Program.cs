using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //using (MyFileWriter myFileWriter = new MyFileWriter("file.txt"))
        //{
        //    myFileWriter.WriteLine("Line 1");
        //    myFileWriter.WriteLine("Line 2");
        //}

        //using (MyFileWriter myFileWriter2 = new MyFileWriter("file.txt"))
        //{
        //    myFileWriter2.WriteLine("Line 1");
        //    myFileWriter2.WriteLine("Line 2");
        //}

        WriteToFile();
        GC.Collect();
        GC.WaitForPendingFinalizers();
        WriteToFile();
    }

    static void WriteToFile()
    {
        MyFileWriter myFileWriter2 = new MyFileWriter("file.txt");
        myFileWriter2.WriteLine("Line 1");
    }
}

public class MyFileWriter : IDisposable
{
    StreamWriter streamWriter;
    public MyFileWriter(string filePath)
    {
        streamWriter = new StreamWriter(filePath, true);
    }

    public void WriteLine(string text)
    {
        streamWriter.WriteLine(text);
        streamWriter.Flush();
    }

    public void Dispose()
    {
        Dispose(true);
    }

    bool disposed;
    protected void Dispose(bool disposing)
    {
        if (disposed)
            return;

        if (disposing)
        {
            //Clean up managed code
            streamWriter.Dispose();
        }
        //clean up unmanaged code
        disposed = true;
    }

    ~MyFileWriter()
    {
        Dispose(false);
    }
}