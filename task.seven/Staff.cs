using System;
namespace task.seven
{
    internal class Staff
    {
        internal static GeneralDirector ReturnPerson(string name)
        {
            switch (name)
            {
                case "Борис":
                    return Boris;
                case "Рашид":
                    return Rashid;
                case "Ильхам":
                    return Ilham;
                case "Оркадий":
                    return Orkadiy;
                case "Володя":
                    return Volodya;
                case "Ильшат":
                    return Ilshat;
                case "Иваныч":
                    return Ivanich;
                case "Илья":
                    return Ilya;
                case "Витя":
                    return Vitya;
                case "Женя":
                    return Zhenya;
                case "Сергей":
                    return Sergey;
                case "Ляйсан":
                    return Laysan;
                case "Марат":
                    return Marat;
                case "Дина":
                    return Dina;
                case "Ильдар":
                    return Ildar;
                case "Антон":
                    return Anton;
            }
            return new GeneralDirector("None");
        }

        internal static GeneralDirector Boris = new GeneralDirector("Борис");
        internal static FinanceDirector Rashid = new FinanceDirector("Рашид");
        internal static AutomationDirector Ilham = new AutomationDirector("Ильхам");
        internal static HeadOfInformationDep Orkadiy = new HeadOfInformationDep("Аркадий");
        internal static HeadOfInformationDep Volodya = new HeadOfInformationDep("Володя");
        internal static HeadOfSystemDep Ilshat = new HeadOfSystemDep("Ильшат");
        internal static DeputyHeadOfSystemDep Ivanich = new DeputyHeadOfSystemDep("Иваныч");
        internal static EmployeeSystemDep Ilya = new EmployeeSystemDep("Илья");
        internal static EmployeeSystemDep Vitya = new EmployeeSystemDep("Витя");
        internal static EmployeeSystemDep Zhenya = new EmployeeSystemDep("Женя");
        internal static HeadOfDevelopmentDep Sergey = new HeadOfDevelopmentDep("Сергей");
        internal static DeputyHeadOfDevelopmentDep Laysan = new DeputyHeadOfDevelopmentDep("Ляйсан");
        internal static EmployeeDevelopmentDep Marat = new EmployeeDevelopmentDep("Марат");
        internal static EmployeeDevelopmentDep Dina = new EmployeeDevelopmentDep("Дина");
        internal static EmployeeDevelopmentDep Ildar = new EmployeeDevelopmentDep("Ильдар");
        internal static EmployeeDevelopmentDep Anton = new EmployeeDevelopmentDep("Антон");
    }
}

