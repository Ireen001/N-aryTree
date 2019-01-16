using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_ary_Tree
{
    public class Tree<T>
    {
        public int Count { get; set; }

        public int LeafCount { get; set;}

        public List<TreeNode<T>> TheTree = new List<TreeNode<T>>();

        public Tree()
        {
            Count = 0;
            LeafCount = 0;
        }

        public TreeNode<T> AddChildNode(TreeNode<T> parentNode, T Value)
        {
            Count++;
            TreeNode<T> newNode = new TreeNode<T>(Value, parentNode);
            if (parentNode != null)
            {
                TheTree.Add(newNode);
                parentNode.Child.Add(newNode);
            }
            else
            {
                TheTree.Add(newNode);

            }
            LeafCount = 0;
            foreach (TreeNode<T> leaf in TheTree)
            {
                if (leaf.Child.Count == 0)
                {
                    LeafCount++;
                }
            }
            return newNode;
        }

        public void removeNode(TreeNode<T> node)
        {
            this.TheTree.Remove(node); // node uit tree halen
            Count--;
            var parentNode = node.Parent; // uit node zijn parent halen
            parentNode.Child.Remove(node); // haal node uit de parent

            if(node.Child.Count != 0)
            {
                for (int i = node.Child.Count - 1; i >= 0; i--)
                {
                    removeNode(node.Child[i]);
                }
            }

            LeafCount = 0;
            foreach (TreeNode<T> leaf in TheTree)
            {
                if (leaf.Child.Count == 0)
                {
                    LeafCount++;
                }
            }
        }
        public List<T> TraverseNodes()
        {
            List<T> traversednodes = new List<T>();

            foreach (TreeNode<T> node in TheTree)
            {
                traversednodes.Add(node.Value);
            }
            return traversednodes;
        }

        public List<T> SumToLeafs()
        {

            List<T> AllSom = new List<T>();
            List<TreeNode<T>> AllLeafs = new List<TreeNode<T>>();
            foreach (TreeNode<T> leaf in TheTree)
            {
                if (leaf.Child.Count == 0)
                {
                    AllLeafs.Add(leaf);
                }
            }
            foreach (TreeNode<T> leafs in AllLeafs)
            {
                int n;

                TreeNode<T> Parent = leafs;
                dynamic Som = 0;
                Som = Som + Parent.Value;
                while (Parent.Parent != null)
                {
                    Som = Som + Parent.Parent.Value;
                    Parent = Parent.Parent;
                }
                AllSom.Add(Som);


            }
            return AllSom;
        }

    }
}
