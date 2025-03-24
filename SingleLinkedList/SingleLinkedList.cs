using System;

namespace doubleandsingle.SingleLinkedList;

public class SingleLinkedList
{
  private Node head;

  public class Node
  {
    public int data;
    public Node next;

    public Node(int d)
    {
      data = d;
      next = null!;
    }
  }

  public SingleLinkedList()
  {
    head = null!;
  }

  public void AddFirst(int data)
  {
    Node newNode = new Node(data);
    newNode.next = head;
    head = newNode;
  }

  public void AddAfter(int after, int data)
  {
    Node current = head;
    while (current != null && current.data != after)
    {
      current = current.next;
    }

    if (current != null)
    {
      Node newNode = new Node(data);
      newNode.next = current.next;
      current.next = newNode;
    }
    else
    {
      Console.WriteLine($"Node dengan data {after} tidak ditemukan.");
    }
  }

  public void AddLast(int data)
  {
    Node newNode = new Node(data);
    if (head == null)
    {
      head = newNode;
      return;
    }

    Node last = GetLastNode();
    last.next = newNode;
  }

  private Node GetLastNode()
  {
    Node temp = head;
    while (temp.next != null)
    {
      temp = temp.next;
    }
    return temp;
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