using System;
using System.Collections.Generic;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool go = true;
            while (go)
            {

                Tasks task = new Tasks();
                ListOfLists tasks = new ListOfLists();

                //task.ParseMethod();

                Tasks.DisplayTaskManager();
                int option = Tasks.ParseMethod();

                if (option == 1)
                {
                    Tasks.DisplayTasks();
                    go = true;
                }
                else if (option == 2)
                {
                    Tasks.AddTask();
                    //go = ListOfLists.tasks.Add(Tasks.AddTask(),option);
                }
                else if (option == 3)
                {
                    Tasks.DeleteTasks();
                    go = true;
                }
                else if (option == 4)
                {
                    //Tasks.TaskComplete
                    Tasks.CompleteTask();
                    go = true;
                }
                else if (option == 5)
                {
                    bool yes = Tasks.Quit();
                    if(yes)
                    {
                        Console.WriteLine("Goodbye. Press any key to leave.");
                        Console.ReadKey(true);
                        break;
                    }
                }


            }

        }

    }      
}




//is being called in the class program
//Display method showing:
//1.List Tasks -- 
//2. Add Tasks
//3. Delete Tasks
//4. Mark task complete
//5. Quit (return false, see you later?)

//infoHelp.RemoveAt(3) ( to remove a task)
//foreach(Tasks d in infoHelp)
//{
// Console.WriteLine("All Tasks: " + d.MemberName);
//Console.WriteLine("All Tasks: " +d.Description);
//Console.WriteLine("All Tasks: " +d.DueDate.ToString("MM-dd-yyyy"));
//Console.WriteLine("All Tasks: " +d.Completed);
//}

//tasks.Add(task);
//tasks.RemoveAt(3) ( to remove a task)


//task.MemberName = "Anthony";
//task.Description = "Does all the things";
//task.Description = DateTime.Parse("07/26/2019".ToString("mm/dd/yyyy"));
//task.Completed = false;