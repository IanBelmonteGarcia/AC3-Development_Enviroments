using System.Security.Cryptography.X509Certificates;

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
            switch(tecla.Key)
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
                    MsgNextScreen("Press a key to exit.");
                    break;
                default:
                    MsgNextScreen("ERROR. Press a key to go back to the menu");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    public static void ShowTopics()
    {
        Console.Clear();
        Console.WriteLine("Option 1: Cinema");
        Console.WriteLine("Option 2: Pokemon");
        Console.WriteLine("Option 3: Game Of Thrones");
        Console.WriteLine("Option 0: Exit");
    }
    public static void Topic1()
    {
        int answ1, answ2, answ3, answ4, answ5, count=0;
        Console.WriteLine("In which of these films Brad Pitt DOESN'T appear");
        Console.WriteLine("1-Fight Club");
        Console.WriteLine("2-Bullet Train");
        Console.WriteLine("3-Ad Astra");
        Console.WriteLine("4-The wolf of wall street");
        Console.Write("Reply with a number 1-4: ");
        answ1 = Convert.ToInt32(Console.ReadLine());
        if (answ1==4) count = count + 1;
        Console.Clear();
        Console.WriteLine("In which of these films WAS directed by Tarantino");
        Console.WriteLine("1-Mary Poppins");
        Console.WriteLine("2-Pulp fiction");
        Console.WriteLine("3-Interestellar");
        Console.WriteLine("4-Avatar 2: The Way of The Water");
        Console.Write("Reply with a number 1-4: ");
        answ2 = Convert.ToInt32(Console.ReadLine());
        if (answ2 == 2) count = count + 1;
        Console.Clear();
        Console.WriteLine("WHO gives voice to the Puss in Boots");
        Console.WriteLine("1-Pedro Pascal");
        Console.WriteLine("2-Matt Damon");
        Console.WriteLine("3-Leonardo DiCaprio");
        Console.WriteLine("4-Antonio Banderas");
        Console.Write("Reply with a number 1-4: ");
        answ3 = Convert.ToInt32(Console.ReadLine());
        if (answ3 == 4) count = count + 1;
        Console.Clear();
        Console.WriteLine("In which of these films Jake Gyenhall DOESN'T appear");
        Console.WriteLine("1-Nightcrawler");
        Console.WriteLine("2-Donnie Darko");
        Console.WriteLine("3-American Psycho");
        Console.WriteLine("4-Prisoners");
        Console.Write("Reply with a number 1-4: ");
        answ4 = Convert.ToInt32(Console.ReadLine());
        if (answ4 == 3) count = count + 1;
        Console.Clear();
        Console.WriteLine("Who preformed Batman in the LASTEST Batman film");
        Console.WriteLine("1-Christian Bale");
        Console.WriteLine("2-Ben Affleck");
        Console.WriteLine("3-Robert Pattinson");
        Console.WriteLine("4-Dwayne 'The Rock' Johnson");
        Console.Write("Reply with a number 1-4: ");
        answ5 = Convert.ToInt32(Console.ReadLine());
        if (answ5 == 3) count = count + 1;
        Console.Clear();
        Console.WriteLine("You got {0} points! Each correct answer values 1 point", count);
        MsgNextScreen("Press a key to go to the menu");
    }
    public static void Topic2()
    {
        int answ1, answ2, answ3, answ4, answ5, count = 0;
        Console.WriteLine("What is Pikachu type?");
        Console.WriteLine("1-Electric");
        Console.WriteLine("2-Flying");
        Console.WriteLine("3-Electric - Water");
        Console.WriteLine("4-Fire");
        Console.Write("Reply with a number 1-4: ");
        answ1 = Convert.ToInt32(Console.ReadLine());
        if (answ1 == 1) count = count + 1;
        Console.Clear();
        Console.WriteLine("Which one is NOT a starter pokemon?");
        Console.WriteLine("1-Charmander");
        Console.WriteLine("2-Bulbasaur");
        Console.WriteLine("3-Staryu");
        Console.WriteLine("4-Squirtle");
        Console.Write("Reply with a number 1-4: ");
        answ2 = Convert.ToInt32(Console.ReadLine());
        if (answ2 == 3) count = count + 1;
        Console.Clear();
        Console.WriteLine("What's the name of the protagonist");
        Console.WriteLine("1-Ash Ketchum");
        Console.WriteLine("2-Brant Peterson");
        Console.WriteLine("3-Peter Parker");
        Console.WriteLine("4-Pikachu");
        Console.Write("Reply with a number 1-4: ");
        answ3 = Convert.ToInt32(Console.ReadLine());
        if (answ3 == 1) count = count + 1;
        Console.Clear();
        Console.WriteLine("Which one of this pokemon IS legendary");
        Console.WriteLine("1-Mewtwo");
        Console.WriteLine("2-Charizard");
        Console.WriteLine("3-Pikachu");
        Console.WriteLine("4-Quilava");
        Console.Write("Reply with a number 1-4: ");
        answ4 = Convert.ToInt32(Console.ReadLine());
        if (answ4 == 1) count = count + 1;
        Console.Clear();
        Console.WriteLine("Which one is NOT a pokemon game title");
        Console.WriteLine("1-Pokemon Fire Red");
        Console.WriteLine("2-Pokemon Water Blue");
        Console.WriteLine("3-Pokemon Leaf Green");
        Console.WriteLine("4-Pokemon SoulSilver");
        Console.Write("Reply with a number 1-4: ");
        answ5 = Convert.ToInt32(Console.ReadLine());
        if (answ5 == 2) count = count + 1;
        Console.Clear();
        Console.WriteLine("You got {0} points! Each correct answer values 1 point", count);
        MsgNextScreen("Press a key to go to the menu");
    }
    public static void Topic3()
    {
        int answ1, answ2, answ3, answ4, answ5, count = 0;
        Console.WriteLine("Who is the rightful heir to the Iron Throne technically");
        Console.WriteLine("1-Aegon Targaryen");
        Console.WriteLine("2-Daenerys Targaryen");
        Console.WriteLine("3-Gendry Baratheon");
        Console.WriteLine("4-Joffrey Baratheon");
        Console.Write("Reply with a number 1-4: ");
        answ1 = Convert.ToInt32(Console.ReadLine());
        if (answ1 == 3) count = count + 1;
        Console.Clear();
        Console.WriteLine("Who was Jon Snow mother?");
        Console.WriteLine("1-Daenerys Targaryen");
        Console.WriteLine("2-Catelyn Stark");
        Console.WriteLine("3-Lyanna Stark");
        Console.WriteLine("4-Johanna Snow");
        Console.Write("Reply with a number 1-4: ");
        answ2 = Convert.ToInt32(Console.ReadLine());
        if (answ2 == 3) count = count + 1;
        Console.Clear();
        Console.WriteLine("Who was known as: The Spider");
        Console.WriteLine("1-Lord Varys");
        Console.WriteLine("2-Olenna Tyrell");
        Console.WriteLine("3-Lord Petyr Baelish");
        Console.WriteLine("4-Corlys Velaryon");
        Console.Write("Reply with a number 1-4: ");
        answ3 = Convert.ToInt32(Console.ReadLine());
        if (answ3 == 1) count = count + 1;
        Console.Clear();
        Console.WriteLine("What's the name of the BIGGEST dragon known?");
        Console.WriteLine("1-Drogon");
        Console.WriteLine("2-Belarion");
        Console.WriteLine("3-Vhagar");
        Console.WriteLine("4-Caraxes");
        Console.Write("Reply with a number 1-4: ");
        answ4 = Convert.ToInt32(Console.ReadLine());
        if (answ4 == 2) count = count + 1;
        Console.Clear();
        Console.WriteLine("Who's the father of Jaime, Tyrion and Cersei");
        Console.WriteLine("1-Jorah Mormont");
        Console.WriteLine("2-Eddard 'Ned' Stark");
        Console.WriteLine("3-Robert Baratheon");
        Console.WriteLine("4-Tywin Lannister");
        Console.Write("Reply with a number 1-4: ");
        answ5 = Convert.ToInt32(Console.ReadLine());
        if (answ5 == 4) count = count + 1;
        Console.Clear();
        Console.WriteLine("You got {0} points! Each correct answer values 1 point", count);
        MsgNextScreen("Press a key to go to the menu");
    }
    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }
}