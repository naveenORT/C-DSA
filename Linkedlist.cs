using System;

namespace Linked_List {
    public class Node {
        public Node next;
        public Node prev;
        public Object data;
    }
    
    public class Linked_List {
        private Node head;
        public void printNodes() {
            Node current = head;
            while (current != null) {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void printNodesReverse() {
            Node prev = null, current = head, next = null;
            while (current != null) {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public void AddFront(Object data) {
            Node toAdd = new Node();
            toAdd.data = data;
            toAdd.next = head;
            head = toAdd;
        }

        public void AddRear(Object data) {
            if (head == null) {
                head = new Node();
                head.data = data;
                head.next = null;
            }
            else {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null) {
                    current = current.next;
                }
                current.next = toAdd;
            }
        }
    }
    public class Double_Linked_List {
        private int data;
        private Double_Linked_List next;
        private Double_Linked_List prev;

            public Double_Linked_List() {
                data = 0;
                next = null;
                prev = null;
            }

            public Double_Linked_List(int value) {
                data = value;
                next = null;
                prev = null;
            }

            public Double_Linked_List InsertNext(int value) {

                Double_Linked_List node = new Double_Linked_List(value);
                
                if(this.next == null) {
                  node.prev = this;
                  node.next = null;                   
                  this.next = node;
                }

                else {
                  Double_Linked_List temp = this.next;
                  node.prev = this;
                  node.next = temp;
                  this.next = node;
                  temp.prev = node;
                }
                
                return node;
            }   
            public Double_Linked_List InsertPrev(int value) {
                Double_Linked_List node = new Double_Linked_List(value);

                if(this.prev == null) {
                  node.prev = null; // already set on constructor
                  node.next = this;
                  this.prev = node;
                }
                else {
                  Double_Linked_List temp = this.prev;
                  node.prev = temp;
                  node.next = this;
                  this.prev = node;
                  temp.next = node;
                }
                return node;
            }

            public void TraverseFront() {
                TraverseFront(this);
            }

            public void TraverseFront(Double_Linked_List node) {

                if(node == null) { 
                        node = this;
                    }
                    
                System.Console.WriteLine("\n\nTraversing in Forward Direction\n\n");

                while(node != null) {
                    System.Console.WriteLine(node.data);
                    node = node.next;
                }
            }

 

      public void TraverseBack() {
         TraverseBack(this);
      }


      public void TraverseBack(Double_Linked_List node) {
            if(node == null) {
            node = this;
            }
            
            System.Console.WriteLine("\n\nTraversing in Backward Direction\n\n");

            while(node != null) {
                  System.Console.WriteLine(node.data);
                  node = node.prev;
            }        
        }
    }
        class Program {
            static void Main(string[] args)
            {
                // Console.WriteLine("Add Front:");
                // Linked_List myList1 = new Linked_List();

                // myList1.AddFront("1");
                // myList1.AddFront("2");
                // myList1.AddFront("3");
                // myList1.printNodes();

                // // Console.WriteLine();

                Console.WriteLine("Add Rear:");
                Linked_List myList2 = new Linked_List();

                myList2.AddRear("1");
                myList2.AddRear("2");
                myList2.AddRear("3");
                // myList2.printNodes();
                // Console.WriteLine();

                myList2.printNodesReverse();
                myList2.printNodes();
                myList2.printNodesReverse();
                myList2.printNodes();
            
            
                Double_Linked_List node1 = new Double_Linked_List(1);
                Double_Linked_List node3 = node1.InsertNext(3);
                Double_Linked_List node2 = node3.InsertPrev(2);
                Double_Linked_List node5 = node3.InsertNext(5);
                Double_Linked_List node4 = node5.InsertPrev(4);

                node1.TraverseFront();
                node5.TraverseBack();
            }
        }
}
