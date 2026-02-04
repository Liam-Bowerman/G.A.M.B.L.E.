using Rainbows;
public static class Roulette
{
    private static string playerColor;
    private static string colorSelected;
    private static int rouletteNum = 0;
    private static int numberCalled;
    private static string numberDisplayed;
    private static bool betOnANumber = true;
    private static int cashBet;
    private static int numberLandedOn;
    public static void EnterRoulette()
    {
        Console.Clear();
        Rainbowify.WriteLineColor("Welcome to roulette!", 255, 60, 170);
        Console.WriteLine("\nStep up to the table.");
        Thread.Sleep(2000);
        StartRoulette();
        RoulletteSpin();
    }
    private static void PlayAgainRoulette()
    {
        Thread.Sleep(1000);
        Console.WriteLine("1. Keep playing \n2. Return to game select \n3. Quit game");
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
                {
                    // Program.PlayPing();
                    Console.Clear();
                    StartRoulette();
                    RoulletteSpin();
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.D2 || keyInfo.Key == ConsoleKey.NumPad2)
                {
                    // Program.PlayPing();
                    Program.GameSelect();
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.D3 || keyInfo.Key == ConsoleKey.NumPad3)
                {
                    // Program.PlayPing();
                    break;
                }
            }
            else
            {
                Thread.Sleep(50);
            }
        }
    }
    private static void StartRoulette()
    {
        Program.GetBalance();
        Console.Write($"Your balance is {Program.balance}");
        Rainbowify.WriteColor(".\n", "white");
        Thread.Sleep(1000);
        Console.WriteLine("How much do you want to bet?");
        Console.Write("$");
        string cashBeingBet = Console.ReadLine();
        // Program.PlayPing();
        try
        {
            cashBet = int.Parse(cashBeingBet);
            if (cashBet > Program.money)
            {
                Console.WriteLine("You do not have enough money.");
                Thread.Sleep(2000);
                Console.Clear();
                StartRoulette();
            }
            else if (cashBet < 0)
            {
                Console.WriteLine("You cannot bet less than $0.");
                Thread.Sleep(2000);
                Console.Clear();
                StartRoulette();
            }
            else
            {
                Thread.Sleep(100);
            }
        }
        catch
        {
            Console.WriteLine("I'm sorry, that is not a valid option. Please enter a valid amount.");
            Thread.Sleep(2000);
            Console.Clear();
            StartRoulette();
        }
        Console.WriteLine("What color? \nRed, Black, or Green?");
        playerColor = Console.ReadLine();
        // Program.PlayPing();
        if (playerColor.ToLower() != "red" & playerColor.ToLower() != "green" & playerColor.ToLower() != "black")
        {
            Console.WriteLine("I'm sorry, that is not a valid option. Please enter Red, Green, or Black");
            Thread.Sleep(2000);
            Console.Clear();
            StartRoulette();
        }
        Console.WriteLine("Do you want to bet on a number? y/n");
        string yesNoForNumber = Console.ReadLine();
        // Program.PlayPing();
        if (yesNoForNumber.ToLower() == "y")
        {
            Console.WriteLine("What number do you want to call? 0-36");
            string numberBetOn = Console.ReadLine();
            // Program.PlayPing();
            try
            {
                numberCalled = int.Parse(numberBetOn);
            }
            catch
            {
                Console.WriteLine("I'm sorry, that is not a valid option. Please chose a number from 0 to 36");
                Thread.Sleep(2000);
                Console.Clear();
                StartRoulette();
            }
        }
        else
        {
            betOnANumber = false;
            Thread.Sleep(500);
        }
    }
    private static void RoulletteSpin()
    {
        Random random = new Random();
        int rouletteSpins = random.Next(74, 150);
        for (int i = 0; i < rouletteSpins; i++)
        {
            Console.Clear();
            Rainbowify.WriteLineColor($"You said {playerColor} {numberCalled}", "white");
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
            Rainbowify.WriteLineColor($"You said {playerColor} {numberCalled}", "white");
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
            Rainbowify.WriteLineColor($"You said {playerColor} {numberCalled}", "white");
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
            Rainbowify.WriteLineColor($"You said {playerColor} {numberCalled}", "white");
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
            Rainbowify.WriteLineColor($"You said {playerColor} {numberCalled}", "white");
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
            Rainbowify.WriteLineColor($"You said {playerColor} {numberCalled}", "white");
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
            Rainbowify.WriteLineColor($"You said {playerColor} {numberCalled}", "white");
            DisplayNum();
            Console.WriteLine(numberDisplayed);
            Thread.Sleep(600);
            rouletteNum++;
            if (rouletteNum > 37)
            {
                rouletteNum = 0;
            }
        }
        if (playerColor == colorSelected && betOnANumber == false)
        {
            Rainbowify.WriteLineColor("You won!", "green");
            Program.money += cashBet;
        }
        else if (playerColor == colorSelected && numberLandedOn == numberCalled)
        {
            Rainbowify.WriteLineColor("You won!", "green");
            Program.money += cashBet;
        }
        else
        {
            Rainbowify.WriteLineColor("You lost...", "red");
            Program.money -= cashBet;
        }
        Thread.Sleep(2000);
        PlayAgainRoulette();
    }
    private static string DisplayNum()
    {
        switch (rouletteNum)
        {
            case 0:
                numberDisplayed = Rainbowify.StoreColor("0", "green");
                colorSelected = "green";
                numberLandedOn = 0;
                break;
            case 1:
                numberDisplayed = Rainbowify.StoreColor("32", "red");
                colorSelected = "red";
                numberLandedOn = 32;
                break;
            case 2:
                numberDisplayed = Rainbowify.StoreColor("15", "black");
                colorSelected = "black";
                numberLandedOn = 15;
                break;
            case 3:
                numberDisplayed = Rainbowify.StoreColor("19", "red");
                colorSelected = "red";
                numberLandedOn = 19;
                break;
            case 4:
                numberDisplayed = Rainbowify.StoreColor("4", "black");
                colorSelected = "black";
                numberLandedOn = 4;
                break;
            case 5:
                numberDisplayed = Rainbowify.StoreColor("21", "red");
                colorSelected = "red";
                numberLandedOn = 21;
                break;
            case 6:
                numberDisplayed = Rainbowify.StoreColor("2", "black");
                colorSelected = "black";
                numberLandedOn = 2;
                break;
            case 7:
                numberDisplayed = Rainbowify.StoreColor("25", "red");
                colorSelected = "red";
                numberLandedOn = 25;
                break;
            case 8:
                numberDisplayed = Rainbowify.StoreColor("17", "black");
                colorSelected = "black";
                numberLandedOn = 17;
                break;
            case 9:
                numberDisplayed = Rainbowify.StoreColor("34", "red");
                colorSelected = "red";
                numberLandedOn = 34;
                break;
            case 10:
                numberDisplayed = Rainbowify.StoreColor("6", "black");
                colorSelected = "black";
                numberLandedOn = 6;
                break;
            case 11:
                numberDisplayed = Rainbowify.StoreColor("27", "red");
                colorSelected = "red";
                numberLandedOn = 27;
                break;
            case 12:
                numberDisplayed = Rainbowify.StoreColor("13", "black");
                colorSelected = "black";
                numberLandedOn = 13;
                break;
            case 13:
                numberDisplayed = Rainbowify.StoreColor("36", "red");
                colorSelected = "red";
                numberLandedOn = 36;
                break;
            case 14:
                numberDisplayed = Rainbowify.StoreColor("11", "black");
                colorSelected = "black";
                numberLandedOn = 11;
                break;
            case 15:
                numberDisplayed = Rainbowify.StoreColor("30", "red");
                colorSelected = "red";
                numberLandedOn = 30;
                break;
            case 16:
                numberDisplayed = Rainbowify.StoreColor("8", "black");
                colorSelected = "black";
                numberLandedOn = 8;
                break;
            case 17:
                numberDisplayed = Rainbowify.StoreColor("23", "red");
                colorSelected = "red";
                numberLandedOn = 23;
                break;
            case 18:
                numberDisplayed = Rainbowify.StoreColor("10", "black");
                colorSelected = "black";
                numberLandedOn = 10;
                break;
            case 19:
                numberDisplayed = Rainbowify.StoreColor("5", "red");
                colorSelected = "red";
                numberLandedOn = 5;
                break;
            case 20:
                numberDisplayed = Rainbowify.StoreColor("24", "black");
                colorSelected = "black";
                numberLandedOn = 24;
                break;
            case 21:
                numberDisplayed = Rainbowify.StoreColor("16", "red");
                colorSelected = "red";
                numberLandedOn = 16;
                break;
            case 22:
                numberDisplayed = Rainbowify.StoreColor("33", "black");
                colorSelected = "black";
                numberLandedOn = 33;
                break;
            case 23:
                numberDisplayed = Rainbowify.StoreColor("1", "red");
                colorSelected = "red";
                numberLandedOn = 1;
                break;
            case 24:
                numberDisplayed = Rainbowify.StoreColor("20", "black");
                colorSelected = "black";
                numberLandedOn = 20;
                break;
            case 25:
                numberDisplayed = Rainbowify.StoreColor("14", "red");
                colorSelected = "red";
                numberLandedOn = 14;
                break;
            case 26:
                numberDisplayed = Rainbowify.StoreColor("31", "black");
                colorSelected = "black";
                numberLandedOn = 31;
                break;
            case 27:
                numberDisplayed = Rainbowify.StoreColor("9", "red");
                colorSelected = "red";
                numberLandedOn = 9;
                break;
            case 28:
                numberDisplayed = Rainbowify.StoreColor("22", "black");
                colorSelected = "black";
                numberLandedOn = 22;
                break;
            case 29:
                numberDisplayed = Rainbowify.StoreColor("18", "red");
                colorSelected = "red";
                numberLandedOn = 18;
                break;
            case 30:
                numberDisplayed = Rainbowify.StoreColor("29", "black");
                colorSelected = "black";
                numberLandedOn = 29;
                break;
            case 31:
                numberDisplayed = Rainbowify.StoreColor("7", "red");
                colorSelected = "red";
                numberLandedOn = 7;
                break;
            case 32:
                numberDisplayed = Rainbowify.StoreColor("28", "black");
                colorSelected = "black";
                numberLandedOn = 28;
                break;
            case 33:
                numberDisplayed = Rainbowify.StoreColor("12", "red");
                colorSelected = "red";
                numberLandedOn = 12;
                break;
            case 34:
                numberDisplayed = Rainbowify.StoreColor("35", "black");
                colorSelected = "black";
                numberLandedOn = 35;
                break;
            case 35:
                numberDisplayed = Rainbowify.StoreColor("3", "red");
                colorSelected = "red";
                numberLandedOn = 3;
                break;
            case 36:
                numberDisplayed = Rainbowify.StoreColor("26", "black");
                colorSelected = "black";
                numberLandedOn = 26;
                break;
        }
        return numberDisplayed;
    }

}