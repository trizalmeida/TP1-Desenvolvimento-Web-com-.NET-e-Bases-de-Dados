using System;

public class TemperatureSensor
{
    public event Action TemperatureExceeded;

    public void CheckTemperature(double temp)
    {
        if (temp > 100)
        {
            TemperatureExceeded?.Invoke();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TemperatureSensor sensor = new TemperatureSensor();

        sensor.TemperatureExceeded += ShowAlert;

        Console.Write("Digite a temperatura atual: ");
        double t = Convert.ToDouble(Console.ReadLine());

        sensor.CheckTemperature(t);

        Console.WriteLine("Leitura concluída.");
    }

    public static void ShowAlert()
    {
        Console.WriteLine("ALERTA: Temperatura acima do limite!");
    }
}
