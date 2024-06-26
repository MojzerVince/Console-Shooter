namespace Console_Shooter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 150;
            Console.WindowHeight = 50;

            while (true)
            {
                Random r = new Random();
                int x = r.Next(0, 150);
                int y = r.Next(0, 25);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.WriteLine(Console.GetCursorPosition());
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ");
                Console.ResetColor();

                Thread.Sleep(3000);
                Console.Clear();
            }
        }
    }
}
