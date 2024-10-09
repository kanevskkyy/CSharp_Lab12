using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
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
}
