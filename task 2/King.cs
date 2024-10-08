using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class King
    {
        public event Action? Attacking;
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
}