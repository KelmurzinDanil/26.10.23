using System;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            new EmployeeClass("генеральный директор", "семен");// 
            new EmployeeClass("финансовый директор", "рашид");// Семену
            new EmployeeClass("директор по автоматизации", "о ильхам");//Семену

            new EmployeeClass("главный в бугалтерии", "лукас"); // Ильхаму
            new EmployeeClass("начальник инф. систем", "оркадий"); // Рашиду
            new EmployeeClass("зам. начальника инф. систем", "володя"); // Рашиду

            new EmployeeClass("главный среди системщиков", "ильшат");// Оркадию и Володи
            new EmployeeClass("зам. главного среди системщиков ", "иваныч");// Ильшату
            new EmployeeClass("сотрудник-системщик-1", "илья");//
            new EmployeeClass("сотрудник-системщик-2", "витя");// Иванычу
            new EmployeeClass("сотрудник-системщик-3", "женя");//

            new EmployeeClass("главный среди разработчиков", "сергей");// Оркадию и Володи
            new EmployeeClass("зам. главный среди разработчиков", "ляйсан");//Сергею
            new EmployeeClass("сотрудник-разработчик-1", "марат");//
            new EmployeeClass("сотрудник-разработчик-2", "дина");//
            new EmployeeClass("сотрудник-разработчик-3", "ильдар");// Ляйсан
            new EmployeeClass("сотрудник-разработчик-4", "антон");//

            EmployeeClass.Print();
            Console.WriteLine("Введите ваше имя");
            string n = Console.ReadLine().ToLower();
            Console.WriteLine("Кому вы хотите отдать задание");
            string k = Console.ReadLine().ToLower();
            switch (n)
            {
                case "семен":
                    switch (k)
                    {
                        case "рашид":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        case "о ильхам":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        default: Console.WriteLine("Вы не можете ему дать задание"); break;
                    }
                    break;
                case "о ильхам":
                    switch (k)
                    {
                        case "оркадий":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        case "володя":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        default: Console.WriteLine("Вы не можете ему дать задание"); break;
                    }
                    break;
                case "рашид":
                    switch (k)
                    {
                        case "лукас":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        default: Console.WriteLine("Вы не можете ему дать задание"); break;
                    }
                    break;
                case "оркадий":
                    switch (k)
                    {
                        case "ильшат":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        case "володя":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        case "сергей":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        default: Console.WriteLine("Вы не можете ему дать задание"); break;
                    }
                    break;
                case "володя":
                    switch (k)
                    {
                        case "ильшат":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        case "сергей":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        default: Console.WriteLine("Вы не можете ему дать задание"); break;
                    }
                    break;
                case "ильшат":
                    switch (k)
                    {
                        case "иваныч":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        default: Console.WriteLine("Вы не можете ему дать задание"); break;
                    }
                    break;
                case "иваныч":
                    switch (k)
                    {
                        case "илья":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        case "витя":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        case "женя":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        default: Console.WriteLine("Вы не можете ему дать задание"); break;
                    }
                    break;
                case "сергей":
                    switch (k)
                    {
                        case "ляйсан":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        default: Console.WriteLine("Вы не можете ему дать задание"); break;
                    }
                    break;
                case "ляйсан":
                    switch (k)
                    {
                        case "марат":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        case "дина":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        case "ильдар":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        case "антон":
                            Console.WriteLine("Он(а) получил(а) задание");
                            break;
                        default: Console.WriteLine("Вы не можете ему дать задание"); break;
                    }
                    break;
                default: Console.WriteLine("Вы не можете раздавать задания"); break;
            }

            Console.ReadKey();




        }
    }
}
