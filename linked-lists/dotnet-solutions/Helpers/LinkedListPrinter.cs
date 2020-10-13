using System;
using System.Collections.Generic;

namespace linked_lists.Helpers
{
  public static class LinkedListPrinter
  {
    public static void PrintLinkedList<T>(LinkedList<T> list)
    {
      var head = list.First; 

      PrintElements<T>(head);
    }

    public static void PrintElements<T>(LinkedListNode<T> node)
    {
      if(node.Value == null) { return; }
      
      Console.Write(node.Value);
      
      if(node.Next != null)
      {
        Console.Write("-> ");
        PrintElements<T>(node.Next);
      }
    }
  }    
}