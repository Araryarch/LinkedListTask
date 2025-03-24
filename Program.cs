using doubleandsingle.SingleLinkedList;
using doubleandsingle.DoubleLinkedList;

namespace LinkedList
{
  class Program
  {
    static void Main(string[] args)
    {
      SingleLinkedList SList = new SingleLinkedList();
      DoubleLinkedList DList = new DoubleLinkedList();

      SList.AddAfter(2, 2);
      SList.AddFirst(1);
      SList.AddLast(3);

      SList.PrintList();

      //==== Double LinkedList ====//
      DList.AddLast(1);
      DList.AddLast(3);
      DList.AddFirst(0);

      DList.AddBefore(DList.tail, 2);

      Console.WriteLine("Double Linked List setelah menambahkan node:");
      DList.PrintList();
    }
  }
}