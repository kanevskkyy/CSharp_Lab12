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
        public int Lives { get; set; }
        public RoyalGuard(string name)
        {
            Name = name;
            Lives = 3;
        }

        public bool isLive()
        {
            return Lives > 0;
        }

        public void Defending()
        {
            Lives--;
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }
}