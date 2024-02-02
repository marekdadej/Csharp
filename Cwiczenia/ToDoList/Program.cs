using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nZarządzanie listą zadań:");
                Console.WriteLine("1. Dodaj zadanie");
                Console.WriteLine("2. Wyświetl zadania");
                Console.WriteLine("3. Usuń zadanie");
                Console.WriteLine("4. Zakończ");

                Console.Write("\nWybierz opcję: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        DisplayTasks();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Nieznana opcja.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Wprowadź nazwę zadania: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Zadanie dodane.");
        }

        static void DisplayTasks()
        {
            Console.WriteLine("\nLista zadań:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        static void RemoveTask()
        {
            DisplayTasks();
            Console.Write("\nWprowadź numer zadania do usunięcia: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber <= tasks.Count && taskNumber > 0)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Zadanie usunięte.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy numer zadania.");
            }
        }
    }
}