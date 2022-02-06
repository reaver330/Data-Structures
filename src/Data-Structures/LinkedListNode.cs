using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedListNode
    {
        public LinkedListNode next { get; set; }
        public LinkedListNode prev { get; set; }
        public long key { get; set; }
        private Boolean isSentinel=false;
        public LinkedListNode(long key)
        {
            this.key = key;
        }
        public LinkedListNode(Boolean isSentinel)
        {
            this.isSentinel = isSentinel;
            this.next = this;
            this.prev = this;
        }
    }
}
