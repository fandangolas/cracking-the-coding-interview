using System;
using System.Collections.Generic;
using linked_lists.Helpers;

namespace linked_lists 
{
    public static class Exercise3
    {
      public static void RunExercise()
      {
        Console.WriteLine("Exercise 3: Delete middle node");

        var list = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

        Console.WriteLine("\n Original Linked List: ");
        Console.Write("    ");
        LinkedListPrinter.PrintLinkedList<int>(list);

        var listWithoutElementToRemove = RemoveElement(list, 4);

        Console.WriteLine("\n Linked List after removing the element '4': ");
        Console.Write("    ");
        LinkedListPrinter.PrintLinkedList<int>(listWithoutElementToRemove);
      }

      public static LinkedList<int> RemoveElement(LinkedList<int> list, int elementToRemove)
      {
        var listWithoutElementToRemove = new LinkedList<int>();

        foreach(var element in list)
        {
          if(element != elementToRemove)
            listWithoutElementToRemove.AddLast(element);
        }

        return listWithoutElementToRemove;
      }
    }
}