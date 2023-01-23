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
            switch(tecla.key)
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
                    MsgNextScreen();
                    break;
                default:
                    MsgNextScreen();
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }
}