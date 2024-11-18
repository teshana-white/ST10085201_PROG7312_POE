using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085201_PROG7312_POE
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public TreeNode<T> Root { get; private set; }

        public void Insert(T data)
        {
            Root = Insert(Root, data);
        }

        private TreeNode<T> Insert(TreeNode<T> node, T data)
        {
            if (node == null)
                return new TreeNode<T>(data);

            if (data.CompareTo(node.Data) < 0)
                node.Left = Insert(node.Left, data);
            else if (data.CompareTo(node.Data) > 0)
                node.Right = Insert(node.Right, data);

            return node;
        }

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
