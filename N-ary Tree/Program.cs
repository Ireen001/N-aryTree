using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_ary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            
            // Rootnode
            var root = tree.AddChildNode(null, 1);

            //Add children to the tree
            var child1 = tree.AddChildNode(root, 2);
            var child2 = tree.AddChildNode(root, 3);
            var child3 = tree.AddChildNode(root, 4);
            var child4 = tree.AddChildNode(root, 5);
            var child5 = tree.AddChildNode(child1, 6);
            var child6 = tree.AddChildNode(child1, 7);
            var child7 = tree.AddChildNode(child2, 8);
            var child8 = tree.AddChildNode(child2, 9);
            var child9 = tree.AddChildNode(child2, 10);
            var child10 = tree.AddChildNode(child4, 11);
            var child11 = tree.AddChildNode(child4, 12);
            var child12 = tree.AddChildNode(child4, 13);
            var child13 = tree.AddChildNode(child6, 14);
            var child14 = tree.AddChildNode(child9, 15);
            var child15 = tree.AddChildNode(child9, 16);
            var child16 = tree.AddChildNode(child12, 17);
            var child17 = tree.AddChildNode(child12, 18);
            var child18 = tree.AddChildNode(child12, 19);

            //Remove child 4
            tree.removeNode(child4);

            //tree.TraverseNodes();
            //List<int> result = NAryTree.TraverseNodes();
            //Console.WriteLine(tree.Count);
            //onsole.WriteLine(tree.LeafCount);

            // Show the leaf sums
            List<int> result = tree.SumToLeafs();
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadLine();

        }
    }
}
