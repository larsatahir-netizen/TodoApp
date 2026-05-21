using Xunit;
using ToDoApp;
using System.Collections.Generic;
public class ToDoListTests
{
    [Fact]
    public void AddTask_ShouldAddTask()
    {
        var todo = new ToDoList();
        todo.AddTask("Testuppgift");

        List<string> tasks = todo.GetAllTasks();
        Assert.Single(tasks);
        Assert.Equal("Testuppgift", tasks[0]);
    }

    [Fact]
    public void RemoveTask_ShouldRemoveTask()
    {
        var todo = new ToDoList();
        todo.AddTask("Test1");
        todo.AddTask("Test2");

        todo.RemoveTask(0);
        List<string> tasks = todo.GetAllTasks();

        Assert.Single(tasks);
        Assert.Equal("Test2", tasks[0]);
    }

    [Fact]
    public void RemoveTask_InvalidIndex_ShouldNotThrow()
    {
        var todo = new ToDoList();
        todo.AddTask("Test1");

        todo.RemoveTask(10);
        List<string> tasks = todo.GetAllTasks();

        Assert.Single(tasks);
        Assert.Equal("Test1", tasks[0]);
    }
}