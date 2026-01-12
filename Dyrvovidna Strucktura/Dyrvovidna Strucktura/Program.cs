namespace Dyrvovidna_Strucktura
{
    class Program
    {
        static void Main()
        {
            BinarySearchTree<string> tree = new BinarySearchTree<string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("1 - Add element");
                Console.WriteLine("2 - Search element");
                Console.WriteLine("3 - Print elements (InOrder)");
                Console.WriteLine("4 - Delete element");
                Console.WriteLine("5 - Print tree structure");
                Console.WriteLine("0 - Exit");


                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter value: ");
                        string addValue = Console.ReadLine();
                        tree.Insert(addValue);
                        Console.WriteLine("Element added.");
                        break;

                    case "2":
                        Console.Write("Enter value to search: ");
                        string searchValue = Console.ReadLine();
                        Console.WriteLine(
                            tree.Search(searchValue)
                                ? "Element found"
                                : "Element not found"
                        );
                        break;

                    case "3":
                        Console.Write("Elements: ");
                        tree.InOrderTraversal();
                        break;

                    case "4":
                        Console.Write("Enter value to delete: ");
                        string deleteValue = Console.ReadLine();
                        tree.Delete(deleteValue);
                        Console.WriteLine("Element deleted (if it existed).");
                        break;

                    case "5":
                        Console.WriteLine("Tree structure:");
                        tree.PrintTree();
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }


                Console.WriteLine();
            }
        }
    }
}
