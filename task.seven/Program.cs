
using System.Runtime.CompilerServices;
using task.seven;

class Program
{
    internal static void Main(String[] args)
    {
        string[] tasks = { "Разработать мобильное приложение", "Сделать алгоритм для видеохостинга",
            "Обновить устаревшее ПО", "Сделать сайт для заказчика" };

        Console.WriteLine("Компания Abibas technology");
        Console.WriteLine($"Штат сотрудников: \n\nГенеральный директор: Борис \nФинансовый директор: Рашид" +
            $"\nДиректор по автоматизации: Ильхам \nНачальник информационных систем: Оркадий \n" +
            $"Заместитель начальника информационных систем: Володя \nСистемщики: \n\tГлавный системщик: Ильшат \n\t" +
            $"Заместитель: Иваныч \n\tСотрудники: Илья, Витя, Женя \nРазработчики: \n\t" +
            $"Главный разработчик: Сергей \n\tЗаместитель: Ляйсан \n\tСотрудники: Марат, Дина, Ильдар, Антон \n");


        Console.WriteLine($"Список задач перед компанией: \n 1 - {tasks[0]} \n 2 - {tasks[1]} \n 3 - {tasks[2]} \n " +
            $"4 - {tasks[3]} \n");
        Console.WriteLine("Введите номер задачи, которую хотите дать одному из работников компании");
        string task = tasks[int.Parse(Console.ReadLine()) - 1];
        Console.WriteLine($"Кому дать задачу <<{task}>>");
        var person1 = Staff.ReturnPerson(Console.ReadLine());
        Console.WriteLine($"Кому {person1.name} отдаст задачу?");
        var person2 = Staff.ReturnPerson(Console.ReadLine());


        Console.WriteLine($"\n{person1.name} дает задачу <<{task}>>, которую исполнит {person2.name} \n");
        if (person2.GetType().IsSubclassOf(person1.GetType()) && person2.number - 1 == person1.number)
        {
            Console.WriteLine($"{person2.name} берет эту задачу");
        }
        else
        {
            Console.WriteLine($"{person2.name} не берет эту задачу");
        }
    }
}



