using System;
using System.Collections.Generic;
using linked_lists.Helpers;

namespace linked_lists
{
  public static class Exercise2
  {
    public static void RunExercise()
    {
      Console.WriteLine("Exercise 2: Return Kth to last");

      var elements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
      var list = new LinkedList<int>(elements);
      
      Console.WriteLine("\n Original Linked List: ");
      Console.Write("    ");
      LinkedListPrinter.PrintLinkedList<int>(list);

      Console.WriteLine("\n Kth to last elements:");

      var zerothElement = FindKthToLast(list, 0);
      Console.WriteLine("    0th to last element: {0}", zerothElement);
      var firstElement = FindKthToLast(list, 1);
      Console.WriteLine("    1st to last element: {0}", firstElement);
      var secondElement = FindKthToLast(list, 2);
      Console.WriteLine("    2nd to last element: {0}", secondElement);
      var thirdElement = FindKthToLast(list, 3);
      Console.WriteLine("    3rd to last element: {0}", thirdElement);

      Console.WriteLine(".\n.\n.\n");
    }

    public static int FindKthToLast(LinkedList<int> list, int k)
    {
      var size = list.Count;
      var elementIndex = size - k;
      var count = 1;

      foreach(var element in list)
      {
        if(count == elementIndex)
        {
          return element;
        }

        else
        {
          count++;
        }
      }

      return 0;
    }
  }
}