using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager
{
    class ListOfLists
    {
        public static List<Tasks> tasks = new List<Tasks> //infoHelp 
                {
                new Tasks("Anthony", "accounting", new DateTime(2019, 09, 23), false),
                new Tasks("Jeff", "Project management", new DateTime(2019, 10, 23), false),
                new Tasks("Bob", "Sales", new DateTime(2019, 09, 23),false),
                new Tasks("Jessica", "HR", new DateTime(2019, 08, 23), false),
                new Tasks("Elliot", "engineering", new DateTime(2019, 11, 23), false)
                };
    }
}
