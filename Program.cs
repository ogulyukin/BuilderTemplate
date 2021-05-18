using System;

namespace OlegGulyukin.Hometask_01
{
    class Program
    {
        static void Build(ref House house, int workers, int teamNumber)
        {
            if (house.getCurrent() == 12)
            {
                Console.Write("House alredy done!!! Nothing to work!");
                return;
            }
            Team team = new Team(Convert.ToString(teamNumber), ref house, workers);
            team.Build();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my house building!");
            House house = new House();
            int workers = -1;
            string input = String.Empty;
            do
            {
                Console.Write("Enter how many workers will build the House:");
                input = Console.ReadLine();
                try
                {
                    workers = Convert.ToInt32(input);
                }
                catch
                {
                    Console.WriteLine("Bad luck! Try again.");
                }
            } while (workers < 0);
            for (int i = 1; workers > 0; i++)
            {
                Program.Build(ref house, workers, i);
                workers -= 3;
            }
        }
    }
}
