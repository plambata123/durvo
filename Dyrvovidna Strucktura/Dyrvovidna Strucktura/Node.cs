using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyrvovidna_Strucktura
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
