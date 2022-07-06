using System;
using System.Collections.Generic;
namespace Colecciones
{
    public class LinkedList
    {
        public static void Main()
        {

            // Create a new LinkedListNode of type String and displays its properties.
            LinkedListNode<String> lln = new LinkedListNode<String>("orange");
            Console.WriteLine("After creating the node ....");
            DisplayProperties(lln);

            // Create a new LinkedList.
            LinkedList<String> ll = new LinkedList<String>();

            // Add the "orange" node and display its properties.
            ll.AddLast(lln);
            Console.WriteLine("After adding the node to the empty LinkedList ....");
            DisplayProperties(lln);

            // Add nodes before and after the "orange" node and display the "orange" node's properties.
            ll.AddFirst("red");
            ll.AddLast("yellow");
            Console.WriteLine("After adding red and yellow ....");
            DisplayProperties(lln);
        }

        public static void DisplayProperties(LinkedListNode<String> lln)
        {
            if (lln.List == null)
                Console.WriteLine("   Node is not linked.");
            else
                Console.WriteLine("   Node belongs to a linked list with {0} elements.", lln.List.Count);

            if (lln.Previous == null)
                Console.WriteLine("   Previous node is null.");
            else
                Console.WriteLine("   Value of previous node: {0}", lln.Previous.Value);

            Console.WriteLine("   Value of current node:  {0}", lln.Value);

            if (lln.Next == null)
                Console.WriteLine("   Next node is null.");
            else
                Console.WriteLine("   Value of next node:     {0}", lln.Next.Value);

            Console.WriteLine();
        }
    }
}