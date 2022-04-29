using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiFoKlasse
{
    class FiFo
    {
        private int[] values;
        private int size = 3;
        private int head = -1;
        private int tail;
        private bool isFull;

        public int[] Values
        {
            get
            {
                int[] filledValues = new int[MaxValidIndex+1];

                for (int i = 0; i <= MaxValidIndex; i++)
                {
                    filledValues[i] = values[i];
                }
                return filledValues;
            }
            private set { values = value; }
          
        }
        public int Size { 
            get => size; 
            private set { size = value; } 
        }
        public int Head { 
            get => head;
            private set { head = value; }
        } 
        public int Tail {
            get => tail;
            private set { tail = value; }
        } 
        public bool IsFull { get => isFull; private set { isFull = value; } }
        public int Min { get => values.Min();}
        public int Max { get => values.Max();}
        public int MaxValidIndex
        {
            get
            {
                if (!isFull)
                {
                    if (head > -1)
                    {
                        if (head < size -1) return head;
                    }
                    else
                    {
                        return 0;
                    }
                }
                return size-1;
            }
        }

        public FiFo ()
        {
            Init();
        }

        public FiFo(int aSize)
        {
            if (aSize >=1)
            {
                Size = aSize;
            }
            Init();
        }

        public void Init()
        {
            values = new int[size];
        }

        public void Clear()
        {
            Init();
        }

        public void WriteValue( int aValue)
        {
            if (head == size-1)
            {
                head = 0;
                tail++;
            }
            else
            {
                head++;
                if (IsFull) tail = tail == size - 1 ? 0 : tail + 1;
                if(!IsFull && head == size - 1) IsFull = true;

            }


            values[head] = aValue;
        }

        public int ReadValue(int index)
        { 
            if (index <= MaxValidIndex)
            {
                return values[index];
            }
            else
            {
                throw new Exception ("invalid index");
            }
        }

        public int[] ReadSortedFiFo()
        {
            int[] sortedValues = new int[MaxValidIndex+1];
            int i;
            int j = 0;

            for(i = tail; i <= MaxValidIndex; i++) 
            { 
                sortedValues[j] = values[i];
                j++; 
            }

            if(IsFull)
            {
                for (i = 0; i < tail; i++)
                {
                    sortedValues[j] = values[i];
                    j++;
                }
            }
            return sortedValues;
        }
     }
}
