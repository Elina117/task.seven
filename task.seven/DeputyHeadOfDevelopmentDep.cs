using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task.seven
{
    internal class DeputyHeadOfDevelopmentDep : HeadOfDevelopmentDep
    {
        internal DeputyHeadOfDevelopmentDep(string name) : base(name) { this.name = name; number = 5; }
    }
}

