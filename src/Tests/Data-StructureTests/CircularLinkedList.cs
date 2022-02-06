using System;
using Xunit;
using DataStructures;

namespace Data_StructureTests
{
    public class CircularLinkedList
    {
        private const int TEN_MILLION = 10000000;

        [Fact]
        public void InsertTenMillionKeys()
        {
            DataStructures.CircularLinkedList ll = new DataStructures.CircularLinkedList();
            for (long l = 0; l <= TEN_MILLION; l++)
            {
                ll.Insert(l);
            }
        }

        [Fact]
        public void SearchTenMillionKeys()
        {
            DataStructures.CircularLinkedList ll = new DataStructures.CircularLinkedList();
            for (long l = 0; l <= TEN_MILLION; l++)
            {
                ll.Insert(l);
            }
            ll.Search(1);
        }

        [Fact]
        public void DeleteOneKeyFromTenMillionKeys()
        {
            DataStructures.CircularLinkedList ll = new DataStructures.CircularLinkedList();
            for (long l = 0; l <= TEN_MILLION; l++)
            {
                ll.Insert(l);
            }
            ll.Delete(1);
        }
    }
}
