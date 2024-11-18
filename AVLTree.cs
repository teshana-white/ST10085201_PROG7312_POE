using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085201_PROG7312_POE
{
    public class AVLTree<T> where T : IComparable<T>
    {
        public TreeNode<T> Root { get; private set; }

        public void Insert(T data)
        {
            Root = Insert(Root, data);
        }

        private TreeNode<T> Insert(TreeNode<T> node, T data)
        {
            if (node == null) return new TreeNode<T>(data);

            if (data.CompareTo(node.Data) < 0)
                node.Left = Insert(node.Left, data);
            else if (data.CompareTo(node.Data) > 0)
                node.Right = Insert(node.Right, data);

            return Balance(node);
        }

        private TreeNode<T> Balance(TreeNode<T> node)
        {
            int balanceFactor = Height(node.Left) - Height(node.Right);

            if (balanceFactor > 1)
            {
                if (Height(node.Left.Left) >= Height(node.Left.Right))
                    node = RotateRight(node);
                else
                {
                    node.Left = RotateLeft(node.Left);
                    node = RotateRight(node);
                }
            }
            else if (balanceFactor < -1)
            {
                if (Height(node.Right.Right) >= Height(node.Right.Left))
                    node = RotateLeft(node);
                else
                {
                    node.Right = RotateRight(node.Right);
                    node = RotateLeft(node);
                }
            }

            return node;
        }

        private int Height(TreeNode<T> node)
        {
            return node == null ? 0 : 1 + Math.Max(Height(node.Left), Height(node.Right));
        }

        private TreeNode<T> RotateLeft(TreeNode<T> x)
        {
            var y = x.Right;
            x.Right = y.Left;
            y.Left = x;
            return y;
        }

        private TreeNode<T> RotateRight(TreeNode<T> y)
        {
            var x = y.Left;
            y.Left = x.Right;
            x.Right = y;
            return x;
        }

        // In-order traversal to get the elements in sorted order
        public void InOrderTraversal(TreeNode<T> node, Action<T> action)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, action);
                action(node.Data);
                InOrderTraversal(node.Right, action);
            }
        }
    }
}
