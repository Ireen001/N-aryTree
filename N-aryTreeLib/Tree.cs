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

        //Add child to the tree
        public TreeNode<T> AddChildNode(TreeNode<T> parentNode, T Value)
        {
            Count++;
            TreeNode<T> newNode = new TreeNode<T>(Value, parentNode);
            //Check if node has a parent, add node to the tree
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

        //Remove node from tree
        public void removeNode(TreeNode<T> node)
        {
            TheTree.Remove(node); // Remove node from the tree
            Count--;
            var parentNode = node.Parent; // Checking who the parent is from the node
            parentNode.Child.Remove(node); // Remove child from parentnode 

            //Remove all children from that node
            if(node.Child.Count != 0)
            {
                for (int i = node.Child.Count - 1; i >= 0; i--)
                {
                    removeNode(node.Child[i]);
                }
            }

            //Count how many leafs without children
            LeafCount = 0;
            foreach (TreeNode<T> leaf in TheTree)
            {
                if (leaf.Child.Count == 0)
                {
                    LeafCount++;
                }
            }
        }

        //Add nodes to list
        public List<T> TraverseNodes()
        {
            List<T> traversednodes = new List<T>();

            foreach (TreeNode<T> node in TheTree)
            {
                traversednodes.Add(node.Value);
            }
            return traversednodes;
        }

        //Return the sum of the leafs
        public List<T> SumToLeafs()
        {

            List<T> AllSom = new List<T>();
            List<TreeNode<T>> AllLeafs = new List<TreeNode<T>>();
            foreach (TreeNode<T> leaf in TheTree)
            {
                if (leaf.Child.Count == 0)
                {
                    //Add all leafs to list
                    AllLeafs.Add(leaf);
                }
            }

           //Sum all leafs
            foreach (TreeNode<T> leafs in AllLeafs)
            {

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
