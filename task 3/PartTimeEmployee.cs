using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class PartTimeEmployee
    {
        public string Name { get; set; }
        public int WeeklyHours { get; set; } = 20;

        public PartTimeEmployee(string name)
        {
            Name = name;
        }
    }
}
