using System;
using System.Collections.Generic;

namespace linked_lists
{
  public static class Exercise1
  {
    public static void RunExercise()
    {
      Console.WriteLine("Exercise 1: Remove duplicates from a Linked List");

      var elements = new int[] { 1, 2, 3, 4, 4, 5, 5, 6, 7, 8, 8 };
      LinkedList<int> list = new LinkedList<int>(elements);
      
      Console.WriteLine("\n");
      Console.WriteLine("List with dups: ");
      foreach (var item in list)
      {
          Console.Write("{0}", item);
      }

      var linkedListWithoutDups = RemoveDuplicates(list);
      
      Console.WriteLine("\n");
      Console.WriteLine("List without dups: ");

      foreach (var item in linkedListWithoutDups)
      {
          Console.Write("{0}", item);
      }
      Console.WriteLine("\n");
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