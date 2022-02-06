using System;
using Xunit;
using DataStructures;


namespace Data_StructureTests
{
    public class B_Tree
    {
        private const int TEN_MILLION = 10000000;

        [Fact]
        public void InsertTenMillionKeys()
        {
            B_tree bt = new B_tree(2);
            try
            {
                System.Diagnostics.Debug.WriteLine("Into 10M BTree test");
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
            B_tree bt = new B_tree(2);
            try
            {
                System.Diagnostics.Debug.WriteLine("Into 10M BTree test");
                for (long l = 0; l <= TEN_MILLION; l++)
                {
                    bt.Insert(l);
                }

                bt.Search(1);

            }
            catch(Exception ex)
            {
                Xunit.Assert.True(false, $"Search failed: {ex.Message}");//fail
            }
            Assert.True(true);//pass
        }
    }
}
