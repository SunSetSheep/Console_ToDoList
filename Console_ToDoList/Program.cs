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
            // create user option varialbe, default to empty string
            string option = "";

            while (option != "e" || option != "E")
            {
                Console.WriteLine("\n Options for managing tasks");
                Console.WriteLine("\n Enter 1 to add a new task");
                Console.WriteLine("\n Enter 2 to remove a task");
                Console.WriteLine("\n Enter 3 to view the whole list");
                Console.WriteLine("\n Enter e to exit the program :) \n");
            }

        }
    }
}
