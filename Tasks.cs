using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager
{
    public class Tasks
    {
        #region Fields
        private string memberName;
        private string description;
        private DateTime dueDate;
        private bool completed;
        #endregion


        public string MemberName
        {
            get
            {
                return memberName;
            }
            set
            {
                memberName = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }
        public bool Completed
        {
            get
            {
                return completed;
            }
            set
            {
                completed = value;
            }
        }
        public Tasks()
        {

        }

        public Tasks(string _memberName, string _description, DateTime _dueDate, bool _complete = false)
        {
            memberName = _memberName;
            description = _description;
            dueDate = _dueDate;
            completed = _complete;
        }
        public static void DisplayTaskManager() //all console write line for this
        {
            Console.WriteLine("Welcome, select an option:\n");
            Console.WriteLine("1. List Tasks."); //plug ParseMethod into here. for all of them.
            Console.WriteLine("2. Add Tasks.");
            Console.WriteLine("3. Delete Tasks.");
            Console.WriteLine("4. Mark Task Complete."); //bool would be true at that point
            Console.WriteLine("5. Quit.");
        }
        public static int ParseMethod()
        {

            try
            {
                int input = int.Parse(Console.ReadLine());
                return input;
            }
            catch (FormatException)
            {
                Console.WriteLine("That was not a number.");
                return ParseMethod();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too large a number");
                return ParseMethod();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.GetType()}.");
                return ParseMethod();
            }

        }

        public static void DisplayTasks()
        {
            foreach (Tasks display in ListOfLists.tasks)
            {
                Console.WriteLine("_________________________________________________");
                Console.WriteLine($"Team member: " + display.MemberName+".");
                Console.WriteLine("Task Description: " + display.Description);
                Console.WriteLine("Due Date: " + display.DueDate+"  " + "Status: " + display.Completed);
                Console.WriteLine("________________________________________________");
            }
        }
        public static void DeleteTasks()
        {
            //ListOfLists.tasks.RemoveAt();
            int num = 1;
            foreach (Tasks item in ListOfLists.tasks)
            {
                Console.WriteLine($"{num}. {item.Description}");
                num++;
            }
            int input = ParseMethod();
            input--;
            try
            {
                ListOfLists.tasks.Remove(ListOfLists.tasks[input]);

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number out of Range.");
                DeleteTasks();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.GetType()}.");
                DeleteTasks();
            }

            //plugging into the list at the top 
            //tasks.Remove(tasks{input});
            /*Console.WriteLine("Delete Tasks: " + delete.MemberName);
            Console.WriteLine("Delete Tasks: " + delete.Description);
            Console.WriteLine("Delete Tasks: " + delete.DueDate.ToString("MM/dd/yyyy"));
            Console.WriteLine("Delete Tasks: " + delete.Completed);*/
        }

        //bool method
        public static void CompleteTask()
        {
            int num = 1;

            Console.WriteLine("Enter task description: ");

            foreach (Tasks item in ListOfLists.tasks)
            {
                Console.WriteLine($"{num}. {item.Description}");
                num++;
            }

            int input = ParseMethod();
            input--;

            try
            {
                bool valid = ListOfLists.tasks[input].Completed; //validating that there is an index at number entered.
                string answer = "";
                while (answer != "y" && answer != "n")
                {
                    Console.WriteLine("Are you sure? y/n.");
                    answer = Console.ReadLine().ToLower();
                }

                if (answer == "y")
                {
                    ListOfLists.tasks[input].Completed = true;
                }
            }
            //string answer = "";
            //while(answer != "y" && answer != "n")
            //{
            //    Console.WriteLine("Are you sure? y/n.");
            //    answer = Console.ReadLine().ToLower();
            //}

            //if (answer == "y")
            //{
            //    ListOfLists.tasks[input].Completed = true;
            //}
            catch
            {
                Console.WriteLine("That was not correct. Try again.");
                CompleteTask();

            }

        }

        public static void AddTask()
        {
            int count = 0;
            Tasks task = new Tasks();
            Console.WriteLine($"Enter team member name.");
            task.MemberName = Console.ReadLine();

            Console.WriteLine("Task description: ");
            task.Description = Console.ReadLine();

            bool again = true;
            while (again)
            {
                Console.WriteLine("enter due date");
                string input = Console.ReadLine();
                if (DateTime.TryParse(input, out DateTime newDate))
                {
                    task.DueDate = newDate;
                    again = false;
                }
                else
                {
                    again = true;
                }
            }
            Console.WriteLine("\nTask completed.\n");
            task.Completed = false;
            ListOfLists.tasks.Add(task);
            count++;//plugging into the list at the top 
        }
        public static bool Quit()
        {

            Console.WriteLine($"Are you sure? y/n");
            char response = Console.ReadKey(true).KeyChar;
            if (response == 'y')
            {
                return true;
            }
            else if (response != 'y')
            {
                return false;
            }
            else
            {
                return Quit();
            }
        }
    }
}
//methods for adding, deleting, methods for updating, 

//lab 9 for quit char response = console.readkey(true).KeyChar
//if (response == 'y')
/*
 * {
 * 
 * return true;
 * 
 * 
 * else if(rsposne != 'y')
 * 
 * return false;
 * 
 * else
 * {
 * 
 * return Quit();*/





