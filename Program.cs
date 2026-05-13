using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Console.WriteLine("Welcome to the To-Do List App!");
List<string> taskList = new List<string>();
string option = "";

while (option != "e")
{
    Console.WriteLine("What woukd you like to do?");
    Console.WriteLine("Enter 1 to add task to the list.");
    Console.WriteLine("Enter 2 to remove a task.");
    Console.WriteLine("Enter 3 to view the list.");
    Console.WriteLine("Enter e to exit the app.");

    option = Console.ReadLine();

    if (option == "1")
    {
        Console.WriteLine("Please enter the name of the task to add to the list");
        string task = Console.ReadLine();
        taskList.Add(task);
        Console.WriteLine($"Task successfully added to the list.");
    }
    else if (option=="2")
    {
        for (int i = 0; i < taskList.Count; i++)
        {
            Console.WriteLine(i + " : " + taskList[i]);
        }
        Console.WriteLine("Please enter the number of the task you would like to remove from the list.");
        int taskNum = Convert.ToInt32(Console.ReadLine());
        taskList.RemoveAt(taskNum);
    }
    else if (option == "3")
    {
        Console.WriteLine("Here is your current to-do list:");
        for (int i = 0; i
            < taskList.Count; i++)
        {
            Console.WriteLine(i + " : " + taskList[i]);
        }

    }
    else if (option == "e")
    {
        Console.WriteLine("Thank you for using the To-Do List App! Goodbye!");
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
    }
}
Console.WriteLine("Thank you for using the To-Do List App! Goodbye!");
