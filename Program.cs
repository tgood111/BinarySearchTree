using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.AddNode(new Node<int>(5));
            bst.AddNode(new Node<int>(3));
            bst.AddNode(new Node<int>(1));
            bst.AddNode(new Node<int>(4));
            bst.AddNode(new Node<int>(6));
            bst.AddNode(new Node<int>(8));
            bst.AddNode(new Node<int>(9));
            bst.AddNode(new Node<int>(7));

            bst.Search(new Node<int>(5000));
        }
    }
}
