using Rainbows;
using NAudio.Wave;
public class Program
{
    private static int i = 1;
    private static bool booleanRepeat = true;
    public static int gameSelect = 1;
    private static string gameSelected = "";
    public static int money = 1000;
    public static void Main(string[] args)
    {
        Console.Clear();
        Rainbowify.WriteLineColor("Welcome to G.A.M.B.L.E.! \nA Game of Autonomous Magic Beholding Lesson-telling Events.", 220, 0, 0);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
        Task task = new Task(() =>
        {
            while (booleanRepeat)
            {
                RainbowFuncForGameSelect("Game select: ", booleanRepeat);
            }
        });
        task.Start();
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
                {
                    gameSelect = 1;
                    gameSelected = "You chose Black Jack!";
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.NumPad2)
                {
                    gameSelect = 2;
                    gameSelected = "You chose Texas Hold 'Em!";
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.D3 || keyInfo.Key == ConsoleKey.NumPad3)
                {
                    gameSelect = 3;
                    gameSelected = "You chose Roulette!";
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.D4 || keyInfo.Key == ConsoleKey.NumPad4)
                {
                    gameSelect = 4;
                    gameSelected = "You chose Horse Racing!";
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.D5 || keyInfo.Key == ConsoleKey.NumPad5)
                {
                    gameSelect = 5;
                    gameSelected = "You chose Slots!";
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.D6 || keyInfo.Key == ConsoleKey.NumPad6)
                {
                    gameSelect = 6;
                    gameSelected = "You chose Poker!";
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.D7 || keyInfo.Key == ConsoleKey.NumPad7)
                {
                    gameSelect = 7;
                    gameSelected = "You chose Guess It!";
                    break;
                }
            }
            else
            {
                Thread.Sleep(50);
            }
        }
        booleanRepeat = false;
        PlayPing();
        Thread.Sleep(2000);
        if (gameSelect == 1)
        {

        }
        else if (gameSelect == 2)
        {

        }
        else if (gameSelect == 3)
        {

        }
        else if (gameSelect == 4)
        {

        }
        else if (gameSelect == 5)
        {

        }
        else if (gameSelect == 6)
        {

        }
        else if (gameSelect == 7)
        {

        }
        else if (gameSelect == 8)
        {

        }
    }
    public static void RainbowFuncForGameSelect(string s, bool boolean)
    {
        string printedRainbow = "";
        foreach (char c in s)
        {
            string foreColor = "\x1b[38;2" + ";" + 255 + ";" + 0 + ";" + 0 + "m";
            switch (i)
            {
                case 1:
                    foreColor = "\x1b[38;2" + ";" + 255 + ";" + 0 + ";" + 0 + "m";
                    printedRainbow += foreColor + c;
                    break;
                case 2:
                    foreColor = "\x1b[38;2" + ";" + 242 + ";" + 136 + ";" + 29 + "m";
                    printedRainbow += foreColor + c;
                    break;
                case 3:
                    foreColor = "\x1b[38;2" + ";" + 255 + ";" + 255 + ";" + 0 + "m";
                    printedRainbow += foreColor + c;
                    break;
                case 4:
                    foreColor = "\x1b[38;2" + ";" + 0 + ";" + 255 + ";" + 0 + "m";
                    printedRainbow += foreColor + c;
                    break;
                case 5:
                    foreColor = "\x1b[38;2" + ";" + 0 + ";" + 0 + ";" + 255 + "m";
                    printedRainbow += foreColor + c;
                    break;
                case 6:
                    foreColor = "\x1b[38;2" + ";" + 128 + ";" + 0 + ";" + 128 + "m";
                    printedRainbow += foreColor + c;
                    break;
                default:
                    break;
            }
            i++;
            if (i > 6)
            {
                i = 1;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.Clear();
        Console.WriteLine(printedRainbow);
        Rainbowify.WriteLineColor("1. Black Jack", 220, 0, 0);
        Rainbowify.WriteLineColor("2. Texas Hold 'Em", 100, 0, 100);
        Rainbowify.WriteLineColor("3. Roulette", 255, 60, 170);
        Rainbowify.WriteLineColor("4. Horse Racing", 0, 100, 0);
        Rainbowify.WriteLineColor("5. Slots", 100, 100, 255);
        Rainbowify.WriteLineColor("6. Poker", 180, 200, 0);
        Rainbowify.WriteLineColor("7. Guess It", 150, 200, 100);
        Rainbowify.WriteLineColor("8. TBD", 100, 255, 255);
        Thread.Sleep(150);
        if (boolean == true)
        {
            boolean = false;
            RainbowFuncForGameSelect(s, booleanRepeat);
        }
        else if (boolean == false)
        {
            booleanRepeat = false;
            Console.WriteLine($"{gameSelected}");
            Thread.Sleep(200);
        }
    }
    public static void PlayPing()
    {
        string audIoFile = "/workspaces/G.A.M.B.L.E./test.mp3";
        using (var audioFile = new AudioFileReader(audIoFile))
        {
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                Thread.Sleep(1000);
                outputDevice.Stop();
            }
        }
    }
}