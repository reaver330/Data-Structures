using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    /// <summary>
    /// Implementation based on Cormen, Thomas H.; Leiserson, Charles E.; Rivest, Ronald L.; Stein, Clifford. 
    /// Introduction to Algorithms (The MIT Press) (p. 484). The MIT Press. Kindle Edition
    /// </summary>
    public class CircularLinkedList
    {
        LinkedListNode sentinel; //the sentinel is a dummy object that allows simlifying the boundary conditions at the head and tail of the list

        public CircularLinkedList(long key)
        {
            sentinel = new LinkedListNode(key);
        }

        public CircularLinkedList()
        {
            sentinel = new LinkedListNode(true);

        }

        public LinkedListNode Insert(long key)
        {
            LinkedListNode x = new LinkedListNode(key); //the new head being inserted

            x.next = this.sentinel.next; //newNode added at the top of the list (this points to the sentinel when its the tail)
            this.sentinel.next.prev = x; //current heads prev points to the new head
            //dont change the sentinels prev when adding at the head of the list
            this.sentinel.next = x; //set the lists head to the new head x
            x.prev = this.sentinel; //the head node's prev (in a circular linked list) points to the sentinel 

            return x;

        }

        public LinkedListNode Search(long key)
        {
            LinkedListNode x = this.sentinel.next;
            while(x != this.sentinel && x.key != key)
            {
                x = x.next;//move to the next node until we find a key that matches or we reach the sentinel
            }
            return x; //x will be null if the key isnt found in the list
        }

        public void Delete(long key)
        {
            LinkedListNode x = this.Search(key);
            Delete(x);
        }
        public void Delete(LinkedListNode x)
        {
            //when using a sentinel the boundary checks can be skipped

            x.prev.next = x.next; //set the next pointers to skip over the removed node
            x.next.prev = x.prev; //set the prev pointer to skip over the removed node

            //Q: what happens to x once the execution leaves this scope? 
            //Q: what happens to x at some point in the future, if anything?
        }

    }
}
