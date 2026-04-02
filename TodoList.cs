using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class ToDoList
    {
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            if (!String.IsNullOrWhiteSpace(task))
            {
                tasks.Add(task);
            }
        }


        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }
        public List<string> GetAllTasks()
        {
            return new List<string>(tasks);
        }
    }
}