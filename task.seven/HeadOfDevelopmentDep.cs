using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task.seven
{
    internal class HeadOfDevelopmentDep : HeadOfInformationDep
    {
        internal HeadOfDevelopmentDep(string name) : base(name) { this.name = name; number = 4; }
    }
}

