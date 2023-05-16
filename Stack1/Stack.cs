using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1
{
    internal class Stack
    {
        int[] v;
        int buff;
        int idx;
        public Stack() 
        {
            buff = 5;
            idx=0;
            v = new int[buff];
        }
        public void Push(int value)
        {
            if(idx==v.Length) 
            {
                int[]t= new int[v.Length+buff];
                for (int i = 0; i < idx; i++)
                {
                    t[i] = v[i];
                }
                t[idx] = value;
                idx++;
                v = t;
            }
            else
            {
                v[idx] = value;
                idx++;
            }
        }
        public void Pop() 
        {
            idx = v.Length;
            if((v.Length-idx)==buff)
            {
                int[]t= new int[v.Length-buff+1];
                for (int i = 0; i < idx; i++)
                {
                    t[i] = v[i];
                }
                idx--;
                v = t;
            }
            else
            {
                int[] t= new int[v.Length-1];
                for (int i = 0; i < idx-1; i++)
                {
                    t[i] = v[i];
                }
                idx--;
                v = t;
            }
        }
        public void view()
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]+" ");
            }
        }
    }
}
