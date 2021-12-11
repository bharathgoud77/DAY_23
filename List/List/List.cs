using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class List
    {
        public static void ListDemo()
        {
            List<int> List = new List<int>();
            List.Add(1);
            List.Add(2);
            List.Add(3);
            List.Add(4);
           
            Console.WriteLine("list contains element  ", List);
             foreach (int obj in List)
            {
                Console.WriteLine( obj);
            }
        }
        
        }
    }
