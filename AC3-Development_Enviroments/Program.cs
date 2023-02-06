internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowTopics();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Topic1();
                    break;
                case ConsoleKey.D2:
                    Topic2();
                    break;
                case ConsoleKey.D3:
                    Topic3();
                    break;
                case ConsoleKey.D0:
                    //MsgNextScreen();
                    break;
                default:
                    //MsgNextScreen();
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    public static void ShowTopics()
    {
        Console.Clear();
        Console.WriteLine("PLEASE SELECT THE TOPIC OF THE QUIZ");
        Console.WriteLine(" ");
        Console.WriteLine("1 - Football");
        Console.WriteLine("2 - Videogames");
        Console.WriteLine("3 - Music");
        Console.WriteLine("0 - EXIT");
    }

    public static void Topic1()
    {
        Console.WriteLine("You choosed football quiz!");

        ConsoleKeyInfo tecla;

        tecla = FPregunta1();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Correct!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Incorrect!");
                break;

        }
        Console.ReadKey();
        tecla = FPregunta2();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Correct!");
                break;

        }
        tecla = FPregunta3();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Correct!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Incorrect!");
                break;

        }
        tecla = FPregunta4();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Correct!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Incorrect!");
                break;

        }
        tecla = FPregunta5();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Correct!");
                break;

        }
        Console.ReadKey();


    }

    public static ConsoleKeyInfo FPregunta1()
    {
        Console.WriteLine("Press any key to start");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("1- Who is the player with most goals of all time?");
        Console.WriteLine(" ");
        Console.WriteLine("A - Lionel Messi");
        Console.WriteLine("B - Cristiano Ronaldo");
        Console.WriteLine("C - Neymar JR");
        Console.WriteLine("D - Erling Halland");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static ConsoleKeyInfo FPregunta2()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("2- Who was the latest player to win the ballon d'or?");
        Console.WriteLine(" ");
        Console.WriteLine("A - Kylian Mbappe");
        Console.WriteLine("B - Lionel Messi");
        Console.WriteLine("C - Robert Lewandowski");
        Console.WriteLine("D - Karim Benzema");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static ConsoleKeyInfo FPregunta3()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("3 - What team was the winner of the last LaLiga and Champions League?");
        Console.WriteLine(" ");
        Console.WriteLine("A - Real Betis");
        Console.WriteLine("B - FC Barcelona");
        Console.WriteLine("C - Real Madrid");
        Console.WriteLine("D - Atletico Madrid");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static ConsoleKeyInfo FPregunta4()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("4 - Who is the player with the most balon d'or?");
        Console.WriteLine(" ");
        Console.WriteLine("A - Lionel Messi");
        Console.WriteLine("B - Pelé");
        Console.WriteLine("C - Johan Cruyff");
        Console.WriteLine("D - Cristiano Ronaldo");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static ConsoleKeyInfo FPregunta5()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("5 - What nation team has the most World cups?");
        Console.WriteLine(" ");
        Console.WriteLine("A - France");
        Console.WriteLine("B - Argentina");
        Console.WriteLine("C - Uruguay");
        Console.WriteLine("D - Brasil");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }

    public static void Topic2()
    {
        Console.WriteLine("You choosed gaming quiz!");

        ConsoleKeyInfo tecla;

        tecla = GPregunta1();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Correct!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Incorrect!");
                break;

        }
        Console.ReadKey();
        tecla = GPregunta2();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Correct!");
                break;

        }
        tecla = GPregunta3();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Correct!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Incorrect!");
                break;

        }
        tecla = GPregunta4();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Correct!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Incorrect!");
                break;

        }
        tecla = GPregunta5();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Correct!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Incorrect!");
                break;

        }
        Console.ReadKey();


    }

    public static ConsoleKeyInfo GPregunta1()
    {
        Console.WriteLine("Press any key to start");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("1- What is the type of game CS:GO?");
        Console.WriteLine(" ");
        Console.WriteLine("1 - Open world");
        Console.WriteLine("2 - Roleplay");
        Console.WriteLine("3 - Shooter");
        Console.WriteLine("4 - Races");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static ConsoleKeyInfo GPregunta2()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("2- In what game appears the character Mario??");
        Console.WriteLine(" ");
        Console.WriteLine("A - Fifa");
        Console.WriteLine("B - Valorant");
        Console.WriteLine("C - League of legends");
        Console.WriteLine("D - Super Smash Bros");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static ConsoleKeyInfo GPregunta3()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("3 - Of what game is the Esports tournament LEC ");
        Console.WriteLine(" ");
        Console.WriteLine("A - Counter Strike");
        Console.WriteLine("B - League of Legends");
        Console.WriteLine("C - Call of duty");
        Console.WriteLine("D - TFT");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static ConsoleKeyInfo GPregunta4()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("4 - What game is the most buyed in history?");
        Console.WriteLine(" ");
        Console.WriteLine("A - Minceraft");
        Console.WriteLine("B - Terraria");
        Console.WriteLine("C - Tetris");
        Console.WriteLine("D - GTA V");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static ConsoleKeyInfo GPregunta5()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("5 - What game of Steam was with the most players at same time?");
        Console.WriteLine(" ");
        Console.WriteLine("A - Dota 2");
        Console.WriteLine("B - Valheim");
        Console.WriteLine("C - PUBG");
        Console.WriteLine("D - Among Us");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static void Topic3()
    {
        Console.WriteLine("You choosed music quiz!");

        ConsoleKeyInfo tecla;

        tecla = MPregunta1();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Correct!");
                break;

        }

        Console.ReadKey();
        tecla = MPregunta2();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Correct!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Incorrect!");
                break;

        }
        tecla = MPregunta3();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Correct!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Incorrect!");
                break;

        }
        tecla = MPregunta4();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Correct!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Incorrect!");
                break;

        }
        tecla = MPregunta5();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.A:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.B:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.C:
                Console.WriteLine("Incorrect!");
                break;

            case ConsoleKey.D:
                Console.WriteLine("Correct!");
                break;

        }
        Console.ReadKey();


    }

    public static ConsoleKeyInfo MPregunta1()
    {
        Console.WriteLine("Press any key to start");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("1- Which of these bands was led by a singer from Africa?");
        Console.WriteLine(" ");
        Console.WriteLine("1 - Jonas Brothers");
        Console.WriteLine("2 - the Who");
        Console.WriteLine("3 - the Beatles");
        Console.WriteLine("4 - Queen");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static ConsoleKeyInfo MPregunta2()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("2- Which of these musical movements did Ludwig van Beethoven help introduce?");
        Console.WriteLine(" ");
        Console.WriteLine("A - Romanticism");
        Console.WriteLine("B - lyricism");
        Console.WriteLine("C - Classicism");
        Console.WriteLine("D - idealism");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static ConsoleKeyInfo MPregunta3()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("3 - Which of these is not a true horn?");
        Console.WriteLine(" ");
        Console.WriteLine("A - trombone");
        Console.WriteLine("B - cornet");
        Console.WriteLine("C - English horn");
        Console.WriteLine("D - French horn");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static ConsoleKeyInfo MPregunta4()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("4 - Where is it thought that the banjo originated?");
        Console.WriteLine(" ");
        Console.WriteLine("A - Africa");
        Console.WriteLine("B - New York City");
        Console.WriteLine("C - Bangladesh");
        Console.WriteLine("D - Coolsville");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }
    public static ConsoleKeyInfo MPregunta5()
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("5 - Which of the following instruments does not employ valves to change pitch?");
        Console.WriteLine(" ");
        Console.WriteLine("A - trombone");
        Console.WriteLine("B - trumpet");
        Console.WriteLine("C - flute");
        Console.WriteLine("D - flugelhorn");

        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();

        return tecla;
    }

}