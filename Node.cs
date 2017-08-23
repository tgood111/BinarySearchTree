using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    public class Node <T>
    {
        public T Data { private set; get; }

        public Node<T> Parent;
        public Node<T> Left;
        public Node<T> Right;

        private Node()
        {
        }

        public Node(T data)
        {
            Data = data;
        }

        public Node(T data, Node<T> parent)
        {
            Data = data;
            Parent = parent;
        }

        public Node(T data, Node<T> parent, Node<T> left, Node<T> right)
        {
            Data = data;
            Parent = parent;
            Left = left;
            Right = right;
        }
    }
}
