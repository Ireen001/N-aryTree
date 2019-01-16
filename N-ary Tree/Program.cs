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
            var NAryTree = new Tree<int>();
            var root = NAryTree.AddChildNode(null, 1);

            var child1 = NAryTree.AddChildNode(root, 2);
            var child2 = NAryTree.AddChildNode(root, 3);
            //var child3 = NAryTree.AddChildNode(root, 4);
            //var child4 = NAryTree.AddChildNode(root, 5);
            //var child5 = NAryTree.AddChildNode(child1, 6);
            //var child6 = NAryTree.AddChildNode(child1, 7);
            //var child7 = NAryTree.AddChildNode(child2, 8);
            //var child8 = NAryTree.AddChildNode(child2, 9);
            //var child9 = NAryTree.AddChildNode(child2, 10);
            //var child10 = NAryTree.AddChildNode(child4, 11);
            //var child11 = NAryTree.AddChildNode(child4, 12);
            //var child12 = NAryTree.AddChildNode(child4, 13);
            //var child13 = NAryTree.AddChildNode(child6, 14);
            //var child14 = NAryTree.AddChildNode(child9, 15);
            //var child15 = NAryTree.AddChildNode(child9, 16);
            //var child16 = NAryTree.AddChildNode(child12, 17);
            //var child17 = NAryTree.AddChildNode(child12, 18);
            //var child18 = NAryTree.AddChildNode(child12, 19);

            //NAryTree.removeNode(child4);
            //NAryTree.TraverseNodes();
            //List<int> hoi = NAryTree.TraverseNodes();
            List<int> hoi = NAryTree.SumToLeafs();
            //Console.WriteLine(NAryTree.LeafCount);
            for (int i = 0; i < hoi.Count; i++)
            {
                Console.WriteLine(hoi[i]);
            }

            Console.ReadLine();

        }
    }
}
