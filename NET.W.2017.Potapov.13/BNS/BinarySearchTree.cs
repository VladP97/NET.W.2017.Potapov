using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNS
{
    public class BinarySearchTree<T>
    {
        private Node<T> root;

        private List<T> nodeValues = new List<T>();

        /// <summary>
        /// Creates BST with generic type root.
        /// </summary>
        /// <param name="root">Root of binary tree</param>
        public BinarySearchTree(T root)
        {
            this.root = new Node<T>(root);
        }

        /// <summary>
        /// Adds element to tree.
        /// </summary>
        /// <param name="element">Element to add.</param>
        public void Add(T element)
        {
            Node<T> newNode = new Node<T>(element);
            Node<T> curNode = root;
            if (root == null)
            {
                root = newNode;
                return;
            }

            while (true)
            {
                if (curNode.CompareTo(newNode.NodeValue) >= 0)
                {
                    if (curNode.Right == null)
                    {
                        curNode.Right = newNode;
                        return;
                    }

                    curNode = curNode.Right;
                }
                else if (curNode.CompareTo(newNode.NodeValue) < 0)
                {
                    if (curNode.Left == null)
                    {
                        curNode.Left = newNode;
                        return;
                    }

                    curNode = curNode.Left;
                }
            }
        }

        /// <summary>
        /// Clears tree.
        /// </summary>
        public void Clear()
        {
            root = null;
        }

        /// <summary>
        /// Determines whether an element is in the BinarySearchList<T>.
        /// </summary>
        /// <param name="value">Value to search.</param>
        /// <returns>True if tree contains value.</returns>
        public bool Contains(T value)
        {
            Node<T> curNode = root;
            Node<T> nodeToSearch = new Node<T>(value);

            while (true)
            {
                if (curNode.CompareTo(nodeToSearch.NodeValue) > 0)
                {
                    if (curNode.Right == null)
                    {
                        return false;
                    }

                    curNode = curNode.Right;
                }

                if (curNode.CompareTo(nodeToSearch.NodeValue) < 0)
                {
                    if (curNode.Left == null)
                    {
                        return false;
                    }

                    curNode = curNode.Left;
                }

                if (curNode.CompareTo(nodeToSearch.NodeValue) == 0)
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Deletes node and all subnodes which contains element.
        /// </summary>
        /// <param name="value">Value to delete.</param>
        public void Delete(T value)
        {
            Node<T> curNode = root;
            Node<T> nodeToSearch = new Node<T>(value);
            Node<T> prevNode = root;
            while (true)
            {
                if (curNode.CompareTo(nodeToSearch.NodeValue) > 0)
                {
                    if (curNode.Right == null)
                    {
                        return;
                    }

                    prevNode = curNode;
                    curNode = curNode.Right;
                }

                if (curNode.CompareTo(nodeToSearch.NodeValue) < 0)
                {
                    if (curNode.Left == null)
                    {
                        return;
                    }

                    prevNode = curNode;
                    curNode = curNode.Left;
                }

                if (curNode.CompareTo(nodeToSearch.NodeValue) == 0)
                {
                    if (prevNode.Right.CompareTo(nodeToSearch.NodeValue) == 0)
                    {
                        prevNode.Right = null;
                        return;
                    }

                    if (prevNode.Left.CompareTo(nodeToSearch.NodeValue) == 0)
                    {
                        prevNode.Left = null;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Preorder passage of binary tree.
        /// </summary>
        /// <returns>Collection of binary tree elements.</returns>
        public IEnumerable<T> PreorderPassage()
        {
            nodeValues = new List<T>();
            PreorderPassageCore(root);
            foreach (var item in nodeValues)
            {
                yield return item;
            }
        }

        /// <summary>
        /// Inorder passage of binary tree.
        /// </summary>
        /// <returns>Collection of binary tree elements.</returns>
        public IEnumerable<T> InorderPassage()
        {
            nodeValues = new List<T>();
            InorderPassageCore(root);
            foreach (var item in nodeValues)
            {
                yield return item;
            }
        }

        /// <summary>
        /// Postorder passage of binary tree.
        /// </summary>
        /// <returns>Collection of binary tree elements.</returns>
        public IEnumerable<T> PostorderPassage()
        {
            nodeValues = new List<T>();
            PostorderPassageCore(root);
            foreach (var item in nodeValues)
            {
                yield return item;
            }
        }

        private void PreorderPassageCore(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            nodeValues.Add(node.NodeValue);
            PreorderPassageCore(node.Left);
            PreorderPassageCore(node.Right);
        }

        private void InorderPassageCore(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            PreorderPassageCore(node.Left);
            nodeValues.Add(node.NodeValue);
            PreorderPassageCore(node.Right);
        }

        private void PostorderPassageCore(Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            PreorderPassageCore(node.Left);
            PreorderPassageCore(node.Right);
            nodeValues.Add(node.NodeValue);
        }
    }
}
