using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task.seven
{
    internal class AutomationDirector : GeneralDirector
    {
        internal AutomationDirector(string name) : base(name) { this.name = name; number = 2; }
    }
}

