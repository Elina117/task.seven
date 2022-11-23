using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task.seven
{
    internal class EmployeeSystemDep : DeputyHeadOfSystemDep
    {
        internal EmployeeSystemDep(string name) : base(name) { this.name = name; number = 6; }
    }
}

