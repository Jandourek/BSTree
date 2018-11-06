using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main()
        {
            BSTree t = new BSTree();

            t.Insert(42);
            t.Insert(45);
            t.Insert(16);
            t.Insert(6);
            t.Insert(20);

            if (t.Search(6))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
    
}