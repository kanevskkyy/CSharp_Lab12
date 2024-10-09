    internal class FootMan
    {
        public string Name { get; set; }
        public FootMan(string name)
        {
            Name = name;
        }

        public void Panic()
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }
    }

    internal class King
    {
        public delegate void AttackDelegate();
        public event AttackDelegate? Attacking;
        public string Name { get; set; }

        public King(string name)
        {
            Name = name;
        }

        public void Attack()
        {
            Console.WriteLine($"King {Name} is under attacking!");
            Attacking?.Invoke();
        }
    }


    internal class RoyalGuard
    {
        public string Name { get; set; }
        public RoyalGuard(string name)
        {
            Name = name;
        }

        public void Defending()
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }