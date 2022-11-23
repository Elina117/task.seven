using System;
namespace task.seven
{
    internal class HeadOfAccounting : FinanceDirector
    {
        internal HeadOfAccounting(string name) : base(name) { this.name = name; number = 3; }
    }
}

