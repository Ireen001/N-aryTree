using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using N_ary_Tree;

namespace N_ary_Tree_Test
{
    [TestFixture]
    public class N_ary_Tree_Test
    {
        [TestCase]
        public void Test_TreeConstructorAddChild()
        {
            //arrange
            var tree = new Tree<int>();

            //act
            var root = tree.AddChildNode(null, 1);
            var child1 = tree.AddChildNode(root, 2); 

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(child1.Parent.Value == 1); //Check if parent of child1 has value 1
                Assert.Contains(child1, tree.TheTree); //Check if child1 is in the tree
            });
        }

        [TestCase]
        public void Test_TreeConstructorDeleteNode()
        {
            //arrange
            var tree = new Tree<int>();
            var root = tree.AddChildNode(null, 1);
            var child1 = tree.AddChildNode(root, 2);
            var child2 = tree.AddChildNode(child1, 3);

            //act
            tree.removeNode(child1); // Remove child1

            //Assert
            Assert.Contains(child2, tree.TheTree); //Check if child2 is in the tree
        }

        [TestCase]
        public void Test_TreeConstructorSumLeafs()
        {
            //arange
            var tree = new Tree<int>();
            var root = tree.AddChildNode(null, 1);
            var child1 = tree.AddChildNode(root, 2);
            var child2 = tree.AddChildNode(child1, 3);

            //act
            List<int> sum = tree.SumToLeafs();

            //assert
            Assert.AreEqual(6 , sum[0]); //Check if sum of first leave is 6
        }
    }
}
