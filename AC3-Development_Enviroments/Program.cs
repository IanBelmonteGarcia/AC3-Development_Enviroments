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
                    //Topic2();
                    break;
                case ConsoleKey.D3:
                    //Topic3();
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
    

}