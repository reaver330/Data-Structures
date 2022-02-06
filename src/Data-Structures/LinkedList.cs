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
    public class LinkedList
    {
        LinkedListNode head;

        public LinkedList(long key)
        {
            head = new LinkedListNode(key);
        }

        public LinkedList()
        {
            head = null;
        }

        public LinkedListNode Insert(long key)
        {
            LinkedListNode x = new LinkedListNode(key); //the new head being inserted
            x.next = this.head; 
            if(this.head is not null)
            {
                this.head.prev = x; //current heads prev points to the new head
            }
            this.head = x; //set the lists head to the new head x
            x.prev = null; //the head node's prev (in a doubly linked list) points nowhere
            return x;
        }

        public LinkedListNode Search(long key)
        {
            LinkedListNode x = this.head;
            while(x is not null && x.key != key)
            {
                x = x.next;//move to the next node until we find a key that matches or we reach the end of the list
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
            if (x.prev is not null)
            {
                x.prev.next = x.next; //set the next pointers to skip over the removed node
            }
            else
            {
                this.head = x.next;
            }

            if (x.next is not null)
            {
                x.next.prev = x.prev; //set the prev pointer to skip over the removed node
            }

            //Q: what happens to x once the execution leaves this scope? 
            //Q: what happens to x at some point in the future, if anything?
        }
    }
}
