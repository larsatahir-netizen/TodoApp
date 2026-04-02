using System;
using ToDoApp;

class Program
{
    static void Main()
    {
        var todoList = new ToDoList();
        bool running = true;

        while (running)
        {
            Console.WriteLine("To do lista");
            Console.WriteLine("1. Visa lista");
            Console.WriteLine("2. Lägg till ny uppgift");
            Console.WriteLine("3. Ta bort uppgift");
            Console.WriteLine("4. Avsluta");
            Console.WriteLine("Välj: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowTasks(todoList);
                    break;

                case "2":
                    AddTask(todoList);
                    break;

                case "3":
                    RemoveTask(todoList);
                    break;

                case "4":
                    running = false;
                    break;
            }
        }
    }

    static void ShowTasks(ToDoList todoList)
    {
        var tasks = todoList.GetAllTasks();

        if (tasks.Count == 0)
        {
            Console.WriteLine("Inga uppgifter");
            return;
        }

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i}: {tasks[i]}");
        }
    }

    static void AddTask(ToDoList todoList)
    {
        Console.WriteLine("Ny uppgift: ");
        string task = Console.ReadLine();

        todoList.AddTask(task);
    }

    static void RemoveTask(ToDoList todoList)
    {
        var tasks = todoList.GetAllTasks();

        if (tasks.Count == 0)
        {
            Console.WriteLine("Inga uppgifter att ta bort");
            return;
        }

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i}: {tasks[i]}");
        }

        Console.WriteLine("Skriv in numret på uppgiften som ska tas bort: ");

        if (int.TryParse(Console.ReadLine(), out int index))
        {
            todoList.RemoveTask(index);
            Console.WriteLine("Uppgift borttagen");
        }
        else
        {
            Console.WriteLine("Fel input");
        }
    }
}