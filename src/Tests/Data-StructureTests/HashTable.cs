using System;
using Xunit;
using DataStructures;

namespace Data_StructureTests
{
    public class Hashtable
    {
        private const int TEN_MILLION = 10000000;

        [Fact]
        public void InsertTenMillionKeys()
        {
            DataStructures.HashTable ht = new DataStructures.HashTable(TEN_MILLION);
            for (long l = 0; l <= TEN_MILLION; l++)
            {
                ht.Insert(l);
            }
        }

        [Fact]
        public void InsertAndSearchTenMillionKeys()
        {
            DataStructures.HashTable ht = new DataStructures.HashTable(TEN_MILLION);
            for (long l = 0; l <= TEN_MILLION; l++)
            {
                ht.Insert(l);
            }
            long? s = ht.Search(1);
            Assert.True(s == 1);
        }

        [Fact]
        public void DeleteOneKeyFromTenMillionKeys()
        {
            DataStructures.HashTable ht = new DataStructures.HashTable(TEN_MILLION);
            for (long l = 0; l <= TEN_MILLION; l++)
            {
                ht.Insert(l);
            }
            ht.Delete(1);
        }
    }
}
