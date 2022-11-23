using System.Text;
using tumakoww;

namespace tumakoww
{
    class Program
    {
        static string StringChange(string str_original)
        {
            StringBuilder str = new StringBuilder(str_original);
            for (int i = 0; i < (str.Length / 2); i++)
            {
                (str[i], str[^(i + 1)]) = (str[^(i + 1)], str[i]);
            }
            string str2 = str.ToString();
            return str2;
        }

        static string ReturnEmail(ref string str)
        {
            string[] temp = str.Split("#");
            str = temp[1];
            return str;
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Задание 1. Сделать операцию перевода со счета на счет \n");
            BankAccount account = new BankAccount(241921424, 15000, BankAccount.AccountType.Накопительный);
            Console.WriteLine($"На ,банковском счету есть {account.balance}р.\n" +
                $"Сколько денег хотите перевести с него на второй счет?");
            uint summa = uint.Parse(Console.ReadLine());
            account.MoneyTransfer(account, summa);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Задание 2. Перевернуть строку \n");
            string str = "1234567";
            Console.WriteLine(StringChange(str));
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Задание 3. Переписать содержимое файла в другой файл \n");
            Console.WriteLine("Введите название файла с его расширением, который хотите обработать");
            //File.Create("C:\\Users\\Никита\\source\\repos\\Work_7\\Tumakov.labs\\bin\\Debug\\net6.0\\new_file3.txt");
            string file3 = Console.ReadLine();
            if (File.Exists(file3))
            {
                StreamReader file = new StreamReader(file3);

                StreamWriter new_file = new StreamWriter("new_file3.txt");
                string str3;
                while ((str3 = file.ReadLine()) != null)
                {
                    new_file.WriteLine(str3.ToUpper());
                }
                new_file.Close();
            }
            else
            {
                Console.WriteLine("Такой файл не существует");
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Задание 5. Перенести список почт в другой файл \n");
            StreamReader file5 = new StreamReader("users.txt");
            //File.Create("C:\\Users\\Никита\\source\\repos\\Work_7\\Tumakov.labs\\bin\\Debug\\net6.0\\email_users5.txt");
            StreamWriter email_users = new StreamWriter("email_users5.txt");
            string str5;
            while ((str5 = file5.ReadLine()) != null)
            {
                email_users.WriteLine(ReturnEmail(ref str5));
            }
            email_users.Close();
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Задание 6. Сравнить 2 песни \n");
            List<Song> songs = new List<Song>
            {
                new Song("Я в моменте", "Джарахов"), new Song("Я в моменте", "Джарахов"),
                new Song("До встречи на танцполе", "Гаязовс Бразерс"), new Song("Сансара", "Баста")
            };

            for (byte i = 0; i < songs.Count; i++)
            {
                songs[i].Title();
            }
            if (Equals(songs[0], songs[1]))
            {
                Console.WriteLine("Первые две песни в списке одинаковые");
            }
            else
            {
                Console.WriteLine("Первые две песни в списке разные");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}

