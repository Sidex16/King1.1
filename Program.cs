namespace King1._1
{
    internal class Program
    {
        static bool isGameEnd = false;
        static List<string> players = new List<string>();
        static List<int> numbers = new List<int>();
        static int numberOfPlayers;
        static Random rand = new Random();

        static void FillPlayers()
        {
            do
            {
                Console.Clear();
                Console.Write("Введіть к-сть гравців: ");
            } while (!int.TryParse(Console.ReadLine(), out numberOfPlayers));


            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.Write($"Введіть гравця номер {i + 1}: ");
                string name = Console.ReadLine();
                players.Add(name);
            }
            Console.CursorVisible = false;
        }
        static void FindKing()
        {

            bool tut;
            int r;
            for (int i = 0; i < players.Count();)
            {
                tut = false;
                r = rand.Next(0, players.Count());
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == r)
                    {
                        tut = true;
                        break;
                    }
                }
                if (!tut)
                {
                    numbers.Add(r);
                    i++;
                }
            }
        }
        static void ShowAllPlayers()
        {
            for (int i = 0; i < players.Count(); i++)
            {
                if (numbers[i] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine($"Король - {players[i]}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < players.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {players[i]}\t {numbers[i]}");
            }
            numbers.Clear();
        }
        static void Hub()
        {
            ConsoleKey consoleKey = Console.ReadKey().Key;
            switch (consoleKey)
            {
                case ConsoleKey.S:
                    Settings();
                    break;
                case ConsoleKey.R:
                    ShowRandomAction("Task.txt");
                    break;
                case ConsoleKey.X:
                    ShowRandomAction("Judgement.txt");
                    break;
                case ConsoleKey.Escape:
                    isGameEnd = true;
                    break;

                default:
                    break;
            }

        }
        static void Settings()
        {
            Console.CursorVisible = true;
            Console.Clear();
            int value, number;
            string newName;
            Console.WriteLine("Виберіть операцію: \n1. Видалити гравця\n2. Додати гравця ");
            Console.SetCursorPosition(19, 0);
            int.TryParse(Console.ReadLine(), out value);
            switch (value)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Гравці:");
                    for (int i = 0; i < players.Count(); i++)
                    {
                        Console.WriteLine($"{i + 1}. {players[i]}");
                    }
                    do
                    {
                        Console.Write("Введіть номер гравця: ");
                    } while (!int.TryParse(Console.ReadLine(), out number));
                    players.RemoveAt(number - 1);
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Введіть нового гравця: ");
                    newName = Console.ReadLine();
                    players.Add(newName);
                    break;
                default:
                    break;
            }
            Console.CursorVisible = false;
        }
        static string[] ReadFile(string path)
        {
            return File.ReadAllLines(path);
        }
        static void ShowRandomAction(string pathToFile)
        {
            Console.Clear();
            string[] tasks = ReadFile(pathToFile);
            Console.WriteLine(tasks[rand.Next(0, tasks.Length)]);
            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            FillPlayers();
            while (!isGameEnd)
            {
                FindKing();
                ShowAllPlayers();
                Hub();
            }
        }
    }
}
