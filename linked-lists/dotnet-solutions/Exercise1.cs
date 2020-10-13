using System;
using System.Collections.Generic;
using linked_lists.Helpers;

namespace linked_lists
{
  public static class Exercise1
  {
    public static void RunExercise()
    {
      Console.WriteLine("Exercise 1: Remove duplicates from a Linked List");

      var elements = new int[] { 1, 2, 3, 4, 4, 5, 5, 6, 7, 8, 8 };
      var list = new LinkedList<int>(elements);
      
      Console.WriteLine("\n Original Linked List: ");
      Console.Write("    ");
      LinkedListPrinter.PrintLinkedList<int>(list);

      var linkedListWithoutDups = RemoveDuplicates(list);
      
      Console.WriteLine("\n Linked List after removing duplicates: ");
      Console.Write("    ");
      LinkedListPrinter.PrintLinkedList<int>(linkedListWithoutDups);

      Console.WriteLine();
    }

    public static LinkedList<int> RemoveDuplicates(LinkedList<int> list)
    {
      var elementCount = new Dictionary<int, int>();
      var filteredLinkedList = new LinkedList<int>();

      foreach (var element in list)
      {
        if(elementCount.ContainsKey(element) == false)
        {
          elementCount.Add(element, 1);
          filteredLinkedList.AddLast(element);
        }

        else
        {
          elementCount[element]++;
        }
      }

      return filteredLinkedList;
    }
  }
}