using System;
using System.Collections.Generic;

namespace linked_lists 
{
    public static class Exercise3
    {
      public static void RunExercise()
      {
        Console.WriteLine("Exercise 3: Delete middle node");

        var list = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

        Console.WriteLine("Original Linked List: ");
        foreach (var item in list)
        {
          Console.Write("{0}", item);
        }
        Console.WriteLine("\n");

        var newList = RemoveElement(list, 4);

        Console.WriteLine("Linked List after removing the element '4': ");
        foreach (var item in newList)
        {
          Console.Write("{0}", item);
        }
        Console.WriteLine("\n");
      }

      public static LinkedList<int> RemoveElement(LinkedList<int> list, int elementToRemove)
      {
        var newList = new LinkedList<int>();

        foreach(var element in list)
        {
          if(element != elementToRemove)
          {
            newList.AddLast(element);
          }
        }

        return newList;
      }
    }
}