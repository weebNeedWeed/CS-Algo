using System;

namespace LearnCS{

  public class Node{
    public int Value {get; set;}
    public Node Next {get; set;}

    public Node(int data){
      Value = data;
      Next = null;
    }
  }

  public class LinkedList{
    private Node head;
    
    public LinkedList(){
      head = null;
    }

    public void AddFirst(int data){
      if(head == null){
        head = new Node(data);
      }else{
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
      }
    }

    public void AddToList(int[] array){
      foreach(var i in array){
        AddFirst(i);
      }
    }

    public void Print(){
      Node last = head;
      while(last != null){
        Console.WriteLine(last.Value);
        last = last.Next;
      }
    }
  }

}
