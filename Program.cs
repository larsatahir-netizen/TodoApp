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
                    ShowTask(todoList);
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
}