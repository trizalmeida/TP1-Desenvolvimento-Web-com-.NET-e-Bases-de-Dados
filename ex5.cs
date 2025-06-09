using System;
using System.Threading;

public class DownloadManager
{
    public event Action DownloadCompleted;

    public void StartDownload()
    {
        Console.WriteLine("Iniciando o download...");
        Thread.Sleep(5000);
        DownloadCompleted?.Invoke();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DownloadManager manager = new DownloadManager();

        manager.DownloadCompleted += ShowMessage;

        manager.StartDownload();
    }

    public static void ShowMessage()
    {
        Console.WriteLine("Download concluído com sucesso!");
    }
}
