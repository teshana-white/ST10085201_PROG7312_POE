using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085201_PROG7312_POE
{
    public class BinaryTree<T> : BasicTree<T>
    {
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
