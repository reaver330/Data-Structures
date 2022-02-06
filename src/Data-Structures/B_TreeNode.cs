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
    public class B_TreeNode
    {
        public long[] keys { get; set; }
        public B_TreeNode[] children { get; set; }
        public int n { get; set; }
        public Boolean isLeaf { get; set; }
        int t = 0;
        public B_TreeNode(int t, Boolean isLeaf)
        {
            this.children = new B_TreeNode[2 * t];
            this.keys = new long[2 * t - 1];
            this.isLeaf = isLeaf;
            this.t = t;
            this.n = 0;
        }

        public void traverse()
        {
            int i;
            for (i = 0; i < n; i++)
            {
                if(!isLeaf)
                {
                    children[i].traverse();
                }
                System.Console.Write($" {keys[i]}");
            }

            if(!isLeaf)
            {
                children[i].traverse();
            }
        }

        public void insertIntoNonFullNode(long k)
        {
            long CHILD_IS_FULL = (2 * t) - 1;
            long i = n - 1;
            if (isLeaf)
            {
                while ((i >= 0) && (k < keys[i]))
                {
                    keys[i + 1] = keys[i];
                    i = i - 1;
                }
                keys[i + 1] = k;
                n = n + 1;
            }
            else
            {
                while ((i >= 0) && (k < keys[i]))
                {
                    i = i - 1;
                }

                B_TreeNode x = children[i + 1];
                if (x.n == CHILD_IS_FULL)
                {
                    splitChild(this, i + 1, true);
                    if (k > x.keys[i + 1])
                    {
                        i = i + 1;
                    }
                }
                x.insertIntoNonFullNode(k);
            }
        }

        public void splitChild(B_TreeNode x, long i, bool random = false)
        {
            //x is the parent node that is to recieve the promoted median key

            //those keys in y that are greater than the median move into z which becomes a new child of x
            
            B_TreeNode y = x.children[i];
            B_TreeNode z = new B_TreeNode(t, y.isLeaf);

            z.n = t - 1;

            //copies the top portion of the keys from y into z
            for (long j = 0; j < t - 1; j++)
            {
                z.keys[j] = y.keys[j + t];
            }

            if (!y.isLeaf)
            {
                for (long j = 0; j < t; j++)
                {
                    z.children[j] = y.children[j + t];
                }
            }

            y.n = t - 1; //reduce y's children to the median - this impl doesnt drop off the duplicate keys because we only ever use n to traverse the tree
            

            for (long j = x.n; j >= i + 1; j--)
            {
                x.children[j + 1] = x.children[j];
            }

            x.children[i + 1] = z;

            for (long j = n - 1; j >= i; j--)
            {
                x.keys[j + 1] = x.keys[j];
            }
            x.keys[i] = y.keys[t - 1];
            x.n = x.n + 1;
        }



        public void splitChild(B_TreeNode y, int i)
        {
            B_TreeNode z = new B_TreeNode(t, y.isLeaf);
            z.n = t - 1;

            for (int j = 0; j < t-1; j++)
            {
                z.keys[j] = y.keys[j + t];
            }

            if (!y.isLeaf)
            {
                for (int j = 0; j < t; j++)
                {
                    z.children[j] = y.children[j + t];
                }
            }

            y.n = t - 1;

            for (int j = n; j >= i+1; j--)
            {
                children[j + 1] = children[j];
            }

            children[i + 1] = z;

            for (int j = n - 1; j >= i; j--)
            {
                keys[j + 1] = keys[j];
            }
            keys[i] = y.keys[t - 1];
            n = n + 1;
        }
    }
}
