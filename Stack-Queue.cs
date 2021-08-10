using System;

namespace Stack
{
    internal class Stack
    {
        static int MAXIMUM = 1000;
        int[] STACK = new int[MAXIMUM];
        static int top;

        public Stack()
        {
            top = -1;
        }
        internal int Pop()
        {
            if (top < 0)
            {
                Console.Write("Stack UnderFlow");
                return 0;
            }
            else
            {
                return STACK[top--];
            }
        }

        internal bool Push(int data)
        {
            if (top >= MAXIMUM)
            {
                Console.Write("Stack OverFlow");
                return false;
            }
            else
            {
                STACK[++top] = data;
                return true;
            }
        }

        internal int Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                return STACK[top];
            }
        }

        internal void PrintStack()
        {
            if (top < 0)
            {
			Console.WriteLine("");
            }
			else{
				Console.WriteLine("Elements in stack");
				for(int i = top; i >=0; i--)
				{
					Console.WriteLine(STACK[i]);
				}
			}
		}
    }

    internal class Queue
    {
        static int MAX = 1000;
        int[] queue = new int[MAX];
        internal int front;
        internal int rear;       
        
        internal int queue_index=0;
        public Queue(){
            front = 0;
            rear = -1; 
        }
    
        internal bool Enqueue(int value){
        if( rear == MAX-1){
            Console.WriteLine("Queue OverFlow");
            return false;
        }
        else {
            queue[++rear] = value;
            return true;
        }
        }    
    
        internal int Dequeue(){
        if( front == rear+1){
            Console.WriteLine("Queue Empty");
            return 0;
        }
        else{    
            Console.WriteLine("deleted element is: " + queue[front]);        
            return queue[front++];
        }
        }
    
        internal void printqueue(){
        
        if(front ==rear+1){
            Console.WriteLine("Queue is Empty");
        }
        else{
        Console.WriteLine("Elements in Queue");
        for(int i = front; i < rear; i++)
        {
        Console.WriteLine(queue[i]);
        }
        }
        }
    }    
    
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);

            myStack.PrintStack();
            myStack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            myStack.PrintStack();

        
            Queue myQueue = new Queue();        

            myQueue.Enqueue(5);
            myQueue.Enqueue(10);
            myQueue.Enqueue(15);
            myQueue.Enqueue(20);
            myQueue.Enqueue(25);
            
            myQueue.printqueue();

            Console.WriteLine("Dequeued Element{0}",myQueue.Dequeue());
            Console.WriteLine("Dequeued Element{0}",myQueue.Dequeue());
            
            myQueue.printqueue();
        }
    }
}
