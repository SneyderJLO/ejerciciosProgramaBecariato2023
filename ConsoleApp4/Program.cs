using System.Text.Json;


class Program
{
    public static Dictionary<string, int>? timers;
    public static void Main()
    {
        timerJson();
    }


    public static void timerJson()
    {
        string jsonFilePath = (@"C:\CURSO_C#\PROYECTO\json\timerParametros.json");


        // Lee todo el contenido del archivo JSON
        string jsonString = File.ReadAllText(jsonFilePath);

        // Deserializa el JSON a un objeto
        // Deserializa el JSON a un objeto
        timers = JsonSerializer.Deserialize<Dictionary<string, int>>(jsonString);
        //var jsonObject = JsonSerializer.Deserialize<Times>(jsonString);
        // Accede a los datos del objeto
        Console.WriteLine($"time: {timers["timer1"]}");
        Console.WriteLine($"time: {timers["timer2"]}");
        Console.WriteLine($"time: {timers["timer3"]}");
        Console.WriteLine($"time: {timers["timer4"]}");
    }
    public class Times
    {
        public string time { get; set; }

    }
}