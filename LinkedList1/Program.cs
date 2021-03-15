using System;

namespace LinkedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            Console.Write("Enter the number of nodes to add: ");
            string totalCount = Console.ReadLine();
            try
            {
                int totalIntCount = int.Parse(totalCount);
                int index = 0;

                while (totalIntCount != 0)
                {
                    try
                    {
                        Console.Write($"Add Node {index}: to LinkedList: ");
                        linkedList.AddNodeToEnd(int.Parse(Console.ReadLine()));
                        totalIntCount--;
                        index++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid data entry.");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid data entry.");
            }

            linkedList.PrintList();
            linkedList.Count();
            linkedList.PrintLastNode();

            Console.WriteLine("\n------------------------------------------------\n");

            linkedList.AddNodeToBeginning(999);
            linkedList.PrintList();
            linkedList.Count();
            linkedList.PrintLastNode();

            Console.WriteLine("\n------------------------------------------------\n");

            linkedList.InsertAfter(0, 2);
            linkedList.PrintList();
            linkedList.Count();
            linkedList.PrintLastNode();

            Console.WriteLine("\n------------------------------------------------\n");

            linkedList.InsertBefore(0, 5);
            linkedList.PrintList();
            linkedList.Count();
            linkedList.PrintLastNode();

            Console.WriteLine("\n------------------------------------------------\n");

            linkedList.InsertAtPosition(55555, 9);
            linkedList.PrintList();
            linkedList.Count();
            linkedList.PrintLastNode();

            Console.WriteLine("\n------------------------------------------------\n");

            linkedList.DeleteNode(5);
            linkedList.PrintList();
            linkedList.Count();
            linkedList.PrintLastNode();

            Console.WriteLine("\n------------------------------------------------\n");

            Console.Write("Enter value to search for: ");
            string searchValue = Console.ReadLine();
            try
            {
                int searchData = int.Parse(searchValue);
                linkedList.Search(searchData);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid data entry.");
            }

            Console.Write("Enter value to search predecessor for: ");
            string searchPredecessorValue = Console.ReadLine();
            try
            {
                int searchData = int.Parse(searchPredecessorValue);
                linkedList.SearchPredecessor(searchData);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid data entry.");
            }

            Console.ReadKey();
        }
    }
}