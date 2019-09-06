// A program that removes Charcter values that are repeated more than 2 times in unsorted single linked list
using System;

namespace LinkedListDemo
{
    class Program  // the class declaration
    {
        Node head; // head of list 

        /* Linked list Node*/
        class Node
        {
            public char data; //declare the list data
            public Node next; //declare the next value after the root node

            /*declare the node function*/
            public Node(char d)
            {
                data = d;
                next = null;
            }
        }
        /* method to delete the duplicate*/
        void deleteNodesRepeatedMorethanTwice()
        {
            /*Temp Reference to head*/
            Node temp = head;

            /* Pointer to store the next 
            pointer of a node to be deleted*/
            Node next_next;

            // do nothing if the list is empty 
            if (head == null)
                return;

            // Traverse list until the last node 
            while (temp.next != null)
            {

                //Compare temp node with the next node 
                if (temp.data == temp.next.data)
                {
                    next_next = temp.next.next;
                    temp.next = null;
                    temp.next = next_next;
                }
                else // advance if no deletion 
                    temp = temp.next;
            }
        }
        /* Inserts a new Node at front of the list. */
        public void push(char new_data)
        {
            /*1 & 2: Allocate the Nodes & 
                    Put in the data*/
            Node new_node = new Node(new_data);

            /*3. Make next of new Node as head*/
            new_node.next = head;

            /* 4. Move the head to point to new Node*/
            head = new_node;
        }

        /* Function to print linked list */
        void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "=>");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        // main method 
        static void Main(string[] args)
        {
            Console.WriteLine("This program deletes character values that are repeated more than twice in the list:");
            // instantiate the LinkedList Object
            Program linkedList = new Program();
            /*Add the element into the list by calling the
             utility method push*/
            linkedList.push('B');
            linkedList.push('A');
            linkedList.push('B');
            linkedList.push('E');
            linkedList.push('E');
            linkedList.push('B');
            linkedList.push('E');
            
            
            //print out the input list before deletion of duplicates
            Console.WriteLine("List before removal of duplicates");
            linkedList.printList();
            // call the method for deleting the duplicates
            linkedList.deleteNodesRepeatedMorethanTwice();

            //print out the output after deletion of duplicates
            Console.WriteLine("List after removal of elements");
            linkedList.printList();
        }
    }
}
