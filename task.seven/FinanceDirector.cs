using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task.seven
{
    internal class FinanceDirector : GeneralDirector
    {
        internal FinanceDirector(string name) : base(name) { this.name = name; number = 2; }
    }
}

