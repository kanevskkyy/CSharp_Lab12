using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class PartTimeEmployee
    {
        public string Name { get; }
        public int WeeklyHours { get; } = 20;

        public PartTimeEmployee(string name)
        {
            Name = name;
        }
    }
}
