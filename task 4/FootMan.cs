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
        public int Lives { get; set; }
        public FootMan(string name)
        {
            Name = name;
            Lives = 2;
        }

        public bool isLive()
        {
            return Lives > 0;
        }

        public void Panic()
        {
            Lives--;
            Console.WriteLine($"Footman {Name} is panicking!");
        }
    }
}
