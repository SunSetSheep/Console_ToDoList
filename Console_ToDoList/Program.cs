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

        }
    }
}
