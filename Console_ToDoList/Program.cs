using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine($"Hello {today:d} to do list !");

            // Create a list to hold the task items
            List<string> taskList = new List<string>();
            // create user option variable, default to empty string
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("\n Options for managing tasks");
                Console.WriteLine("\n Enter 1 to add a new task");
                Console.WriteLine("\n Enter 2 to remove a task");
                Console.WriteLine("\n Enter 3 to view the whole list");
                Console.WriteLine("\n Enter e to exit the program :) \n");

                // Read the users inputted value
                option = Console.ReadLine();

                // Add item to list
                if (option == "1")
                {
                    // Ask user to enter a new task name
                    Console.WriteLine("Enter new task name \n ");
                    // Read the response
                    string newTask = Console.ReadLine();
                    // Add it to the list
                    taskList.Add(newTask);
                    Console.WriteLine("Task added to the list \n");
                }
                // Delete an item from the list
                else if (option == "2")
                {
                    // Iterate through the list 
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + ":" + taskList[i]);
                    }
                    // Tell user to input a task number to be removed
                    Console.WriteLine("Enter the task number you'd like to remove \n ");
                    // Convert string into int
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Task removed from the list \n ");
                }
                // View of tasks in the list
                else if (option == "3")
                {

                    Console.WriteLine("All the tasks in the to do list: \n");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }

                }
                // Close the program
                else if (option == "E" || option == "e")
                {
                    Console.WriteLine("Closing program \n ");
                }
                // Error handling 
                else
                {
                    Console.WriteLine("Invalid option, please try again using the valid options shown !");
                }
            }
            

            










        }
    }
}
