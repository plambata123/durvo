using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyrvovidna_Strucktura
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public void Insert(T value)
        {
            root = InsertRecursive(root, value);
        }

        private Node<T> InsertRecursive(Node<T> current, T value)
        {
            if (current == null)
            {
                return new Node<T>(value);
            }

            if (value.CompareTo(current.Value) < 0)
            {
                current.Left = InsertRecursive(current.Left, value);
            }
            else if (value.CompareTo(current.Value) > 0)
            {
                current.Right = InsertRecursive(current.Right, value);
            }

            return current;
        }

        public bool Search(T value)
        {
            return SearchRecursive(root, value);
        }

        private bool SearchRecursive(Node<T> current, T value)
        {
            if (current == null)
            {
                return false;
            }

            if (value.CompareTo(current.Value) == 0)
            {
                return true;
            }

            if (value.CompareTo(current.Value) < 0)
            {
                return SearchRecursive(current.Left, value);
            }

            return SearchRecursive(current.Right, value);
        }

        public void Delete(T value)
        {
            root = DeleteRecursive(root, value);
        }

        private Node<T> DeleteRecursive(Node<T> current, T value)
        {
            if (current == null)
            {
                return null;
            }

            if (value.CompareTo(current.Value) < 0)
            {
                current.Left = DeleteRecursive(current.Left, value);
            }
            else if (value.CompareTo(current.Value) > 0)
            {
                current.Right = DeleteRecursive(current.Right, value);
            }
            else
            {
                if (current.Left == null && current.Right == null)
                {
                    return null;
                }

                if (current.Left == null)
                {
                    return current.Right;
                }

                if (current.Right == null)
                {
                    return current.Left;
                }

                T smallestValue = FindSmallestValue(current.Right);
                current.Value = smallestValue;
                current.Right = DeleteRecursive(current.Right, smallestValue);
            }

            return current;
        }


        public void PrintTree()
        {
            PrintTreeRecursive(root, 0);
        }

        private void PrintTreeRecursive(Node<T> node, int level)
        {
            if (node == null)
            {
                return;
            }

            PrintTreeRecursive(node.Right, level + 1);

            Console.WriteLine(new string(' ', level * 4) + node.Value);

            PrintTreeRecursive(node.Left, level + 1);
        }

        private T FindSmallestValue(Node<T> node)
        {
            return node.Left == null
                ? node.Value
                : FindSmallestValue(node.Left);
        }

        public void InOrderTraversal()
        {
            InOrderRecursive(root);
            Console.WriteLine();
        }

        private void InOrderRecursive(Node<T> current)
        {
            if (current == null)
            {
                return;
            }

            InOrderRecursive(current.Left);
            Console.Write(current.Value + " ");
            InOrderRecursive(current.Right);
        }
    }
}
