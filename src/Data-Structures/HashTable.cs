using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class HashTable
    {
        private long size = 0; //slot count
        private LinkedList[] T;

        public HashTable(long size)
        {
            this.size = size;
            T = new LinkedList[size];//init the table to the provided size
        }

        public long? Search(long key)
        {
            LinkedListNode s = T[DivisionMethodHash(key)].Search(key);
            if (s is not null)
                return s.key;

            return null;
        }

        public void Insert(long key)
        {
            T[DivisionMethodHash(key)] = new LinkedList(); ;
            T[DivisionMethodHash(key)].Insert(key);
        }

        public void Delete(long key)
        {
            long? s = this.Search(key);
            if (s is null)
                return;

            T[DivisionMethodHash(key)].Delete(key);

        }

        private long DivisionMethodHash(long key)
        {
            return key % size;
        }
    }
}
