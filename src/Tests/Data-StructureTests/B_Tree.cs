using System;
using Xunit;
using DataStructures;
using System.Collections.Generic;

namespace Data_StructureTests
{
    public class B_Tree
    {
        private const int TEN_MILLION = 10000000;
        private B_tree bt;

        public B_Tree()
        {
            InsertTenMillionKeys();
        }

        [Fact]
        public void TraverseFullTree()
        {
            try
            {
                bt = new B_tree(2);

                bt.Insert(10);
                bt.Insert(30);
                bt.Insert(5);
                bt.Insert(6);
                bt.Insert(20);
                bt.Insert(12);

                List<long> results = new List<long>();
                bt.CopyToList(results);

                Assert.True(results[0] == 5);
                Assert.True(results[1] == 6);
                Assert.True(results[2] == 10);
                Assert.True(results[3] == 12);
                Assert.True(results[4] == 20);
                Assert.True(results[5] == 30);

                bt = new B_tree(2);
            }
            catch (Exception ex)
            {
                Xunit.Assert.True(false, $"Insert failed: {ex.Message}");//fail
            }
            Assert.True(true);//pass
        }

        [Fact]
        public void InsertTenMillionKeys()
        {
            try
            {
                bt = new B_tree(2);

                for (long l = 0; l <= TEN_MILLION; l++)
                {
                    bt.Insert(l);
                }
            }
            catch(Exception ex)
            {
                Xunit.Assert.True(false, $"Insert failed: {ex.Message}");//fail
            }
            Assert.True(true);//pass
        }

        [Fact]
        public void SearchInSetOfTenMillionKeys()
        {
            try
            {
                KeyValuePair<B_TreeNode, long>? s = bt.Search(1);
                Assert.True(s is not null);
                Assert.True((s.Value).Value == 1);
            }
            catch(Exception ex)
            {
                Xunit.Assert.True(false, $"Search failed: {ex.Message}");//fail
            }
            Assert.True(true);//pass
        }

        [Fact]
        public void InsertDuplicateKeys()
        {
            try
            {
                bt = new B_tree(1);

                for (long l = 1; l <= 3; l++)
                {
                    bt.Insert(l);
                }

                for (long l = 1; l <= 3; l++)
                {
                    bt.Insert(l);
                }
            }
            catch (Exception ex)
            {
                Xunit.Assert.True(false, $"Insert failed: {ex.Message}");//fail
            }
            Assert.True(true);//pass
        }

        [Fact]
        public void InsertDuplicateAndSearchThemKeys()
        {
            try
            {
                bt = new B_tree(2);

                for (long l = 1; l <= 3; l++)
                {
                    bt.Insert(l);
                }

                for (long l = 1; l <= 3; l++)
                {
                    bt.Insert(l);
                }
                KeyValuePair<B_TreeNode, long>? s = bt.Search(1);
                Assert.True(s is not null);
                Assert.True((s.Value).Value == 1);
            }
            catch (Exception ex)
            {
                Xunit.Assert.True(false, $"Insert failed: {ex.Message}");//fail
            }
            Assert.True(true);//pass
        }
    }
}
