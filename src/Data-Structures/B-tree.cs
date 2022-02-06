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
    public class B_tree
    {
        public B_TreeNode Root { get; set; }
        private int t=0;
        /// <summary>
        /// constructs the empty tree
        /// </summary>
        public B_tree(int degree)
        {
            if (degree < 2)
                throw new ApplicationException("b-tree degree must be 2 or greater");

            this.Root = null;
            t = degree;
        }

        public void traverse()
        {
            if (Root != null)
                Root.traverse();
        }

        /// <summary>
        /// copies the whole b-tree's keys to the provided list
        /// </summary>
        /// <param name="results"></param>
        public void CopyToList(List<long> results)
        {
            if (Root != null)
                Root.CopyToList(results);
        }

        public KeyValuePair<B_TreeNode, int>? Search(int k)
        {
            return SearchSubtree(Root, k);
        }

        /// <summary>
        /// search the provided sub-tree starting at x for the value k
        /// </summary>
        /// <param name="k">the key to search for</param>
        /// <returns>a pair containing the node that holds k and the index i of k in the nodes keys</returns>
        private  KeyValuePair<B_TreeNode,int>? SearchSubtree(B_TreeNode x, int k)
        {
            int i = 0;
            while( (i < x.n) && (k > x.keys[i]))
            {
                i = i + 1;
            }
            if(k == x.keys[i])
            {
                return new KeyValuePair<B_TreeNode, int>(x, i);
            }
            else
            {
                if(x.isLeaf)
                {
                    return null;
                }
                else
                {
                    return SearchSubtree(x.children[i], k);
                }
            }
        }

        /// <summary>
        /// inserts a key into the tree
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public void Insert(long k)
        {
            int CHILD_IS_FULL = 2 * t - 1;
            if (Root is null)
            {
                Root = new B_TreeNode(t, true);
                Root.keys[0] = k;
                Root.n=1;
            }
            else
            {
                B_TreeNode r = this.Root;
                if (r.n == CHILD_IS_FULL)
                {
                    B_TreeNode s = new B_TreeNode(t, false);
                    s.children[0] = r;
                    r.splitChild(s, 0, true);

                    int i = 0;
                    if(s.keys[0] < k)
                        i++;

                    s.children[i].insertIntoNonFullNode(k);
                    Root = s;
                }
                else
                {
                    r.insertIntoNonFullNode(k);
                }
            }
        }

        public void Delete(long k)
        {
            throw new NotImplementedException("The delete function on a b-tree is very complex and so I plan to implement it at another time");
        }
    }
}
