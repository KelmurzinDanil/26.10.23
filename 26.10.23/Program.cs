using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace _26._10._23
{
    internal class Program
    {
        static int EnterNumber() // Проверка на целое число
        {
            bool flag = true;
            int number;
            do
            {
                Console.WriteLine("Введите число:");
                bool isNumber = int.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести число");
                }
            }
            while (flag);

            return number;
        }
        static decimal DecimalNumber() // Проверка на число
        {
            bool flag = true;
            decimal number;
            do
            {
                Console.WriteLine("Введите число:");
                bool isNumber = decimal.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести число");
                }
            }
            while (flag);

            return number;
        }
        public static string FlipString(string str) //8.4
        {
            char[] characters = str.ToCharArray();
            List<char> flipList = new List<char>(characters);
            flipList.Reverse();
            foreach (char c in flipList)
            {
                Console.Write(c);
            }



            return str;
        }
        public static void SearchMail(ref string s) // Поиск Email
        {
            const string MatchEmailPattern =
            @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
            + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
            + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
            + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";

            Regex rx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(s); // Успешные совпадения
            string newPath = "NewFile.txt";
            File.WriteAllText("NewFile.txt", string.Empty);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.ToString());
                using (StreamWriter writer = new StreamWriter(newPath, true))
                {
                    writer.WriteLine(match.Value.ToString());
                }
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("8.1");
            Bank_8 bank = new Bank_8(12345, 200000, 500);
            Console.WriteLine(bank);
            Console.WriteLine("Вы хотите внести деньги *1*, снять *2* или перекинуть *3* на другой аккаунт(Напишите на соответствующию цифру)");
            int p = EnterNumber();
            Console.WriteLine("Какую сумму?");
            decimal amount = DecimalNumber();
            if (p <= 3)
            {
                switch (p)
                {
                    case 1:
                        bank.Deposit(amount);
                        break;
                    case 2:
                        bank.Withdraw(amount);
                        break;
                    case 3:
                        bank.Transfer(amount);
                        break;
                }
                Console.WriteLine(bank);
            }
            else { Console.WriteLine("Такой операции не существует"); }


            Console.WriteLine("8.2");
            Console.WriteLine("Введите тип string:");
            string str = Console.ReadLine();
            FlipString(str);

            Console.WriteLine();

            Console.WriteLine("8.3");
            Console.WriteLine("Введите имя файла");
            string nameFile = Console.ReadLine();
            string path = $"{nameFile}.txt";

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    Console.WriteLine($"{reader.ReadToEnd().ToUpper()}");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }
            Console.WriteLine("8.1 Дз");
            string path1 = "EmailFile.txt";
            try
            {
                using (StreamReader reader = new StreamReader(path1))
                {
                    string s = reader.ReadToEnd().ToString();
                    SearchMail(ref s);
                }
            }
            catch (FileNotFoundException) { Console.WriteLine("Файл не найден"); }

            Console.WriteLine("8.2 Дз");
            List<Song> song = new List<Song>();
            Song song1 = new Song();
            song1.Name("Лампабикт");
            song1.Author("Крылья");
            song.Add(song1);
            Song song2 = new Song();
            song2.Name("Мой Июль");
            song2.Author("Грязь");
            song.Add(song2);
            Song song3 = new Song();
            song3.Name("FIZICA");
            song3.Author("Готем");
            song.Add(song3);
            Song song4 = new Song();
            song4.Name("Roman Lewis");
            song4.Author("Ways");
            song.Add(song4);
            foreach(Song s in song)
            {
                s.PrintSong();
            }

            song1.Equals(song2); // сравнение


            Console.ReadKey();
        }
    }
}
