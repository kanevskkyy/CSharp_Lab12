using System;
using task_2;

class Task
{
    static void Main()
    {
        string kingInformation = Console.ReadLine();
        string[] royalInformation = Console.ReadLine().Split();
        string[] footInformation = Console.ReadLine().Split();

        King king = new King(kingInformation);

        List<RoyalGuard> royalGuards = new List<RoyalGuard>();
        List<FootMan> footMan = new List<FootMan>();

        foreach(string name in royalInformation)
        {
            RoyalGuard royalGuard = new RoyalGuard(name);
            royalGuards.Add(royalGuard);
            king.Attacking += royalGuard.Defending;
        }

        foreach (string name in footInformation)
        {
            FootMan footman = new FootMan(name);
            footMan.Add(footman);
            king.Attacking += footman.Panic;
        }
        Line();

        while (true)
        {
            Console.Write("Enter command = ");
            string[] commands = Console.ReadLine().Split();

            if (commands[0] == "End") break;

            else if (commands[0] == "Attack" && commands[1] == "King") king.Attack();
            else if (commands[0] == "Kill")
            {
                for (int i = 0; i < footMan.Count; i++)
                {
                    if (footMan[i].Name == commands[1])
                    {
                        king.Attacking -= footMan[i].Panic;
                        footMan.RemoveAt(i);
                    }
                }
                for (int i = 0; i < royalGuards.Count; i++)
                {
                    if (royalGuards[i].Name == commands[1])
                    {
                        king.Attacking -= royalGuards[i].Defending;
                        royalGuards.RemoveAt(i);
                    }
                }
            }

            else Console.WriteLine("Invalid command!");
            Line();
        }


    }
    public static void Line()
    {
        Console.WriteLine("=======================================");
    }
}