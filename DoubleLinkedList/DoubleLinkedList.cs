using System;

namespace doubleandsingle.DoubleLinkedList;

public class DoubleLinkedList
{
  public Node head;
  public Node tail;

  public class Node
  {
    public int data;
    public Node prev;
    public Node next;

    public Node(int d)
    {
      data = d;
      prev = null!;
      next = null!;
    }
  }

  public DoubleLinkedList()
  {
    head = null!;
    tail = null!;
  }

  public void AddFirst(int data)
  {
    Node newNode = new Node(data);
    newNode.next = head;
    newNode.prev = null!;

    if (head != null)
    {
      head.prev = newNode;
    }

    head = newNode;

    if (tail == null)
    {
      tail = newNode;
    }
  }

  public void AddLast(int data)
  {
    Node newNode = new Node(data);
    newNode.next = null!;
    newNode.prev = tail;

    if (tail != null)
    {
      tail.next = newNode;
    }

    tail = newNode;

    if (head == null)
    {
      head = newNode;
    }
  }

  public void AddAfter(Node prevNode, int data)
  {
    if (prevNode == null)
    {
      Console.WriteLine("Node sebelumnya tidak boleh null");
      return;
    }

    Node newNode = new Node(data);
    newNode.next = prevNode.next;
    prevNode.next = newNode;
    newNode.prev = prevNode;

    if (newNode.next != null)
    {
      newNode.next.prev = newNode;
    }
    else
    {
      tail = newNode;
    }
  }

  public void AddBefore(Node nextNode, int data)
  {
    if (nextNode == null)
    {
      Console.WriteLine("Node berikutnya tidak boleh null");
      return;
    }

    Node newNode = new Node(data);
    newNode.prev = nextNode.prev;
    nextNode.prev = newNode;
    newNode.next = nextNode;

    if (newNode.prev != null)
    {
      newNode.prev.next = newNode;
    }
    else
    {
      head = newNode;
    }
  }

  public void PrintList()
  {
    Node temp = head;
    while (temp != null)
    {
      Console.Write(temp.data + " ");
      temp = temp.next;
    }
    Console.WriteLine();
  }
}
