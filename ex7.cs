using System;
using System.IO;

public class Logger
{
    public void LogToConsole(string message)
    {
        Console.WriteLine($"[Console] {message}");
    }

    public void LogToFile(string message)
    {
        File.AppendAllText("log.txt", $"[Arquivo] {message}\n");
    }

    public void LogToDatabase(string message)
    {
        Console.WriteLine($"[Banco de Dados] (simulado) {message}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = new Logger();

        Action<string> logAction = null;

        logAction?.Invoke("Esta mensagem não causará nenhum erro, pois não há métodos criados ainda.");

        logAction += logger.LogToConsole;
        logAction += logger.LogToFile;
        logAction += logger.LogToDatabase;

        logAction?.Invoke("Registro realizado.");
    }
}
