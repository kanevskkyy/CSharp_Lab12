using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
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
}