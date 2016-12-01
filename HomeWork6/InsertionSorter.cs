using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public class InsertionSorter : Sorter
    {
       
        public InsertionSorter(int[] Array) : base(Array)
        {
            
        }

        public override void Sort()
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {

                    Swap(i - 1, i);

                    for (int j = (i - 1); j > 0; j--)
                    {
                        if (array[j] < array[j - 1])
                        {
                            Swap(j - 1, j);
                        }

                        else
                        {
                            break;
                        }
                    }

                }

            }
        }
    }
}
