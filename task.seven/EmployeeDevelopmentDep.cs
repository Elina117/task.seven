using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task.seven
{
    internal class EmployeeDevelopmentDep : DeputyHeadOfDevelopmentDep
    {
        internal EmployeeDevelopmentDep(string name) : base(name) { this.name = name; number = 6; }
    }
}

