using System;

namespace LinkedList1
{
    public class LinkedList
    {
        int count;
        Node head;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void AddNodeToBeginning(int data)
        {
            Node node = new Node(data);
            node.link = head;
            head = node;
        }

        public void InsertBefore(int data, int x)
        {
            Node node;

            if (head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }

            // If x is in first node, then the new node is to be inserted before the first node.
            if (x == head.data)
            {
                node = new Node(data);
                node.link = head;
                head = node;
                return;
            }

            // Find the reference to the predecessor of node containing x
            Node p = head;
            while (p.link != null)
            {
                if (p.link.data == x)
                {
                    break;
                }
                p = p.link;
            }

            if (p.link == null)
            {
                Console.WriteLine(x + " not present in the list");
            }
            else
            {
                node = new Node(data);
                node.link = p.link;
                p.link = node;
            }

        }

        public void InsertAtPosition(int data, int k)
        {
            Node node;
            int i;

            if (k == 1)
            {
                node = new Node(data);
                node.link = head;
                head = node;
                return;
            }

            Node p = head;
            for (i = 1; i < k - 1 && p != null; i++)
            {
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine("You can only insert up to " + i + "th position");
            }
            else
            {
                node = new Node(data);
                node.link = p.link;
                p.link = node;
            }
        }

        public void InsertAfter(int data, int x)
        {
            Node p = head;
            while (p != null)
            {
                if (p.data == x)
                {
                    break;
                }
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine(x + " not present in the list");
            }
            else
            {
                Node node = new Node(data);
                node.link = p.link;
                p.link = node;
            }
        }

        public void AddNodeToEnd(int data)
        {
            Node p;
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
                return;
            }
            p = head;

            while (p.link != null)
            {
                p = p.link;
            }
            p.link = node;
        }

        public void Count()
        {
            count = 0;
            Node runner = head;
            while (runner != null)
            {
                count++;
                runner = runner.link;
            }
            Console.WriteLine("\nTotal count of nodes: " + count);
        }

        public void Search(int x)
        {
            Node runner = head;
            while (runner != null)
            {
                if (runner.data == x)
                {
                    break;
                }
                runner = runner.link;
            }
            if (runner != null)
            {
                Console.WriteLine("Data found: " + runner.data);
            }
            else
            {
                Console.WriteLine("Could not find data.");
            }
        }

        public void SearchPredecessor(int x)
        {
            Node runner = head;
            while (runner.link != null)
            {
                if (runner.link.data == x)
                {
                    break;
                }
                runner = runner.link;
            }
            if (runner != null)
            {
                Console.WriteLine("Data found: " + runner.data);
            }
            else
            {
                Console.WriteLine("Could not find data.");
            }
        }

        public void DeleteFirstNode()
        {
            if (head == null)
            {
                return;
            }
            head = head.link;
        }

        public void DeleteLastNode()
        {
            if (head == null)
            {
                return;
            }

            if (head.link == null)
            {
                head = null;
                return;
            }

            Node p = head;
            while (p.link.link != null)
            {
                p = p.link;
            }
            p.link = null;
        }

        public void DeleteNode(int x)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty\n");
                return;
            }

            if (head.data == x)
            {
                head = head.link;
                return;
            }

            Node p = head;
            while (p.link != null)
            {
                if (p.link.data == x)
                {
                    break;
                }
                p = p.link;
            }

            if (p.link == null)
            {
                Console.WriteLine("Element " + x + " not in list");
            }
            else
            {
                p.link = p.link.link;
            }
        }

        public void PrintList()
        {
            Console.WriteLine("Nodes: ");
            Node runner = head;
            while (runner != null)
            {
                Console.Write(runner.data + "\t");
                runner = runner.link;
            }
        }

        public void PrintLastNode()
        {
            Console.Write("\nLast Node: ");
            Node runner = head;
            while (runner.link != null)
            {
                runner = runner.link;
                if (runner.link == null)
                {
                    Console.WriteLine(runner.data + "\n");
                }
            }
        }
    }
}