using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
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
}
