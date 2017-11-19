using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNS
{
    public class Node<T> : IEqualityComparer<T>, IComparable<T>
    {
        private T nodeValue;
        private Node<T> left;
        private Node<T> right;

        /// <summary>
        /// Creates new node by value.
        /// </summary>
        /// <param name="nodeValue">Value to storage.</param>
        public Node(T nodeValue)
        {
            this.nodeValue = nodeValue;
        }

        /// <summary>
        /// Left node of tree.
        /// </summary>
        public Node<T> Left
        {
            get { return left; }
            set { left = value; }
        }

        /// <summary>
        /// Right node of tree.
        /// </summary>
        public Node<T> Right
        {
            get { return right; }
            set { right = value; }
        }

        /// <summary>
        /// Value of current node.
        /// </summary>
        public T NodeValue
        {
            get { return nodeValue; }
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj1">The object to compare with the current object.</param>
        /// <param name="obj2">The object to compare with the current object.</param>
        /// <returns>true if the specified objects is equals; otherwise, false.</returns>
        public bool Equals(T obj1, T obj2)
        {
            if (ReferenceEquals(obj1, obj2))
            {
                return true;
            }

            if (obj1.GetType() != obj2.GetType())
            {
                return false;
            }

            return obj1.Equals(obj2);
        }

        /// <summary>
        /// Returns hash of object.
        /// </summary>
        /// <param name="obj">Object to get hash.</param>
        /// <returns>A hash code for the object object.</returns>
        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }

        /// <summary>
        /// Returns hash of object current value of node.
        /// </summary>
        /// <returns>Hash of value of node.</returns>
        public override int GetHashCode()
        {
            return nodeValue.GetHashCode();
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>A value that indicates the relative order of the objects being compared.</returns>
        public int CompareTo(T obj)
        {
            if (typeof(T).GetInterfaces().Contains(typeof(IComparer<T>)))
            {
                return CustomCompareTo(obj as IComparer<T>);
            }

            return GetHashCode() - obj.GetHashCode();
        }
        
        private int CustomCompareTo(IComparer<T> obj)
        {
            return obj.Compare(nodeValue, (T)obj);
        }
    }
}
