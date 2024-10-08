using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class StandardEmployee
    {
        public string Name { get; }
        public int WeeklyHours { get; } = 40;
        public StandardEmployee(string name)
        {
            Name = name;
        }

    }
}
