using System.Collections.Generic;

namespace BinarySearchTreeProject
{
    public class BinarySearchTree<T>
    {
        private Node<T> _root;

        public BinarySearchTree()
        {
            _root = null;
        }

        public BinarySearchTree(Node<T> root)
        {
            _root = root;
            _root.Parent = root;
        }

        public void AddNode(Node<T> newNode)
        {
            if (_root == null)
            {
                _root = newNode;
                _root.Parent = _root;
                return;
            }

            Node<T> current = _root;
            while (true)
            {
                // Less then case --> Go left
                if (Comparer<T>.Default.Compare(newNode.Data, current.Data) == -1)
                {
                    if (current.Left == null)
                    {
                        newNode.Parent = current;
                        current.Left = newNode;
                        return;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }

                // Greater then case --> Go right
                else
                {
                    if (current.Right == null)
                    {
                        newNode.Parent = current;
                        current.Right = newNode;
                        return;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }

        public bool Search(Node<T> searchTerm)
        {
            Node<T> current = _root;
            while (current != null)
            {
                if (Comparer<T>.Default.Compare(current.Data, searchTerm.Data) == 0)
                {
                    return true;
                }

                if (Comparer<T>.Default.Compare(searchTerm.Data, current.Data) == -1)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return false;
        }

    }
}