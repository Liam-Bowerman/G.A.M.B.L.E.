using Rainbows;
public static class Roulette
{
    private static string playerColor;
    private static string colorSelected;
    private static int rouletteNum = 0;
    private static string numberDisplayed;
    public static void EnterRoulette()
    {
        Console.Clear();
        Rainbowify.WriteLineColor("Welcome to the roulette table!", 255, 60, 170);
        Console.Write($"Your balance is {Program.balance}");
        Rainbowify.WriteColor(".\n", "white");
        Thread.Sleep(1000);
        Console.WriteLine("\nStep up to the table.");
        Thread.Sleep(2000);
        Console.WriteLine("What color? \nRed, Black, or Green?");
        playerColor = Console.ReadLine();
        RoulletteSpin();
    }
    private static void RoulletteSpin()
    {
        //37 spaces
        Random random = new Random();
        int rouletteSpins = random.Next(74, 150);
        for (int i = 0; i < rouletteSpins; i++)
        {
            Console.Clear();
            Rainbowify.WriteLineColor($"You said {playerColor}", "white");
            DisplayNum();
            Console.WriteLine(numberDisplayed);
            Thread.Sleep(25);
            rouletteNum++;
            if (rouletteNum > 37)
            {
                rouletteNum = 0;
            }
        }
        for (int i = 0; i < 20; i++)
        {
            Console.Clear();
            Rainbowify.WriteLineColor($"You said {playerColor}", "white");
            DisplayNum();
            Console.WriteLine(numberDisplayed);
            Thread.Sleep(50);
            rouletteNum++;
            if (rouletteNum > 37)
            {
                rouletteNum = 0;
            }
        }
        for (int i = 0; i < 15; i++)
        {
            Console.Clear();
            Rainbowify.WriteLineColor($"You said {playerColor}", "white");
            DisplayNum();
            Console.WriteLine(numberDisplayed);
            Thread.Sleep(75);
            rouletteNum++;
            if (rouletteNum > 37)
            {
                rouletteNum = 0;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            Console.Clear();
            Rainbowify.WriteLineColor($"You said {playerColor}", "white");
            DisplayNum();
            Console.WriteLine(numberDisplayed);
            Thread.Sleep(125);
            rouletteNum++;
            if (rouletteNum > 37)
            {
                rouletteNum = 0;
            }
        }
        for (int i = 0; i < 15; i++)
        {
            Console.Clear();
            Rainbowify.WriteLineColor($"You said {playerColor}", "white");
            DisplayNum();
            Console.WriteLine(numberDisplayed);
            Thread.Sleep(200);
            rouletteNum++;
            if (rouletteNum > 37)
            {
                rouletteNum = 0;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            Console.Clear();
            Rainbowify.WriteLineColor($"You said {playerColor}", "white");
            DisplayNum();
            Console.WriteLine(numberDisplayed);
            Thread.Sleep(400);
            rouletteNum++;
            if (rouletteNum > 37)
            {
                rouletteNum = 0;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            Console.Clear();
            Rainbowify.WriteLineColor($"You said {playerColor}", "white");
            DisplayNum();
            Console.WriteLine(numberDisplayed);
            Thread.Sleep(600);
            rouletteNum++;
            if (rouletteNum > 37)
            {
                rouletteNum = 0;
            }
        }
    }
    private static string DisplayNum()
    {
        switch (rouletteNum)
        {
            case 0:
                numberDisplayed = Rainbowify.StoreColor("0", "green");
                colorSelected = "green";
                break;
            case 1:
                numberDisplayed = Rainbowify.StoreColor("32", "red");
                colorSelected = "red";
                break;
            case 2:
                numberDisplayed = Rainbowify.StoreColor("15", "black");
                colorSelected = "black";
                break;
            case 3:
                numberDisplayed = Rainbowify.StoreColor("19", "red");
                colorSelected = "red";
                break;
            case 4:
                numberDisplayed = Rainbowify.StoreColor("4", "black");
                colorSelected = "black";
                break;
            case 5:
                numberDisplayed = Rainbowify.StoreColor("21", "red");
                colorSelected = "red";
                break;
            case 6:
                numberDisplayed = Rainbowify.StoreColor("2", "black");
                colorSelected = "black";
                break;
            case 7:
                numberDisplayed = Rainbowify.StoreColor("25", "red");
                colorSelected = "red";
                break;
            case 8:
                numberDisplayed = Rainbowify.StoreColor("17", "black");
                colorSelected = "black";
                break;
            case 9:
                numberDisplayed = Rainbowify.StoreColor("34", "red");
                colorSelected = "red";
                break;
            case 10:
                numberDisplayed = Rainbowify.StoreColor("6", "black");
                colorSelected = "black";
                break;
            case 11:
                numberDisplayed = Rainbowify.StoreColor("27", "red");
                colorSelected = "red";
                break;
            case 12:
                numberDisplayed = Rainbowify.StoreColor("13", "black");
                colorSelected = "black";
                break;
            case 13:
                numberDisplayed = Rainbowify.StoreColor("36", "red");
                colorSelected = "red";
                break;
            case 14:
                numberDisplayed = Rainbowify.StoreColor("11", "black");
                colorSelected = "black";
                break;
            case 15:
                numberDisplayed = Rainbowify.StoreColor("30", "red");
                colorSelected = "red";
                break;
            case 16:
                numberDisplayed = Rainbowify.StoreColor("8", "black");
                colorSelected = "black";
                break;
            case 17:
                numberDisplayed = Rainbowify.StoreColor("23", "red");
                colorSelected = "red";
                break;
            case 18:
                numberDisplayed = Rainbowify.StoreColor("10", "black");
                colorSelected = "black";
                break;
            case 19:
                numberDisplayed = Rainbowify.StoreColor("5", "red");
                colorSelected = "red";
                break;
            case 20:
                numberDisplayed = Rainbowify.StoreColor("24", "black");
                colorSelected = "black";
                break;
            case 21:
                numberDisplayed = Rainbowify.StoreColor("16", "red");
                colorSelected = "red";
                break;
            case 22:
                numberDisplayed = Rainbowify.StoreColor("33", "black");
                colorSelected = "black";
                break;
            case 23:
                numberDisplayed = Rainbowify.StoreColor("1", "red");
                colorSelected = "red";
                break;
            case 24:
                numberDisplayed = Rainbowify.StoreColor("20", "black");
                colorSelected = "black";
                break;
            case 25:
                numberDisplayed = Rainbowify.StoreColor("14", "red");
                colorSelected = "red";
                break;
            case 26:
                numberDisplayed = Rainbowify.StoreColor("31", "black");
                colorSelected = "black";
                break;
            case 27:
                numberDisplayed = Rainbowify.StoreColor("9", "red");
                colorSelected = "red";
                break;
            case 28:
                numberDisplayed = Rainbowify.StoreColor("22", "black");
                colorSelected = "black";
                break;
            case 29:
                numberDisplayed = Rainbowify.StoreColor("18", "red");
                colorSelected = "red";
                break;
            case 30:
                numberDisplayed = Rainbowify.StoreColor("29", "black");
                colorSelected = "black";
                break;
            case 31:
                numberDisplayed = Rainbowify.StoreColor("7", "red");
                colorSelected = "red";
                break;
            case 32:
                numberDisplayed = Rainbowify.StoreColor("28", "black");
                colorSelected = "black";
                break;
            case 33:
                numberDisplayed = Rainbowify.StoreColor("12", "red");
                colorSelected = "red";
                break;
            case 34:
                numberDisplayed = Rainbowify.StoreColor("35", "black");
                colorSelected = "black";
                break;
            case 35:
                numberDisplayed = Rainbowify.StoreColor("3", "red");
                colorSelected = "red";
                break;
            case 36:
                numberDisplayed = Rainbowify.StoreColor("26", "black");
                colorSelected = "black";
                break;
        }
        return numberDisplayed;
    }
}