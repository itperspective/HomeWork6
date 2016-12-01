using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public class Sorter
    {
        protected int[] array;
        private int swap;

        public Sorter(int[] Array)
        {
            this.array = Array;
        }

        public void Swap(int swap1, int swap2)
        {
            swap = array[swap1];
            array[swap1] = array[swap2];
            array[swap2] = swap;
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
            Console.Write("]");
        }

        public virtual void Sort()
        {
            for (int i = 0; i < (array.Length - 1); i++)
            {
                if (array[i + 1] < array[i])
                {
                    Swap(i, i + 1);
                    i = -1;
                }
            }
        } 
    }
}
