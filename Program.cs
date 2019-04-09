using System;
using System.Collections.Generic;
namespace Week_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();
                while (true)
                {
                {
                    
                }
                    {
                        Console.WriteLine("Welcome to your list!");
                        string command = Console.ReadLine();
                        if(command == "Add")
                        {
                            Console.WriteLine("enter text!");
                            string item = Console.ReadLine();
                            toDoList.Add(item);
                        }

                        else if(command == "View"){
                         if(toDoList.Count == 0){
                              Console.WriteLine("You have no items in the list");
                         }
                           Console.WriteLine(toDoList.Count);
                            ViewList(toDoList);
                           
                        
                        }

                        
            

                            else if(command == "Exit"){
                                break;
                            }

                    }
                }
        }
    public static void ViewList(List<string> list){
        foreach(string A in list){
            Console.WriteLine("-" + A);
        }
    }
}
}