using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class CArray
    {
        private int[] arr;
        private int numElements;
        private int upper;

        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }
        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }
        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void Clear()
        {
            for (int i = 0; i <=upper; i++)
            {
                arr[i] = 0;
                numElements = 0;
            }
        }
        public  void BubbleSort()
        {
            int temp;
            for (int outer= upper; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer-1; inner++)
                {
                    if (arr[inner]>arr[inner+1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                    Console.WriteLine("");
                    this.DisplayElements();
                }
                
            }
        }
        public void SelectionSort()
        {
            int temp, min;
            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = outer+1; inner <=outer; inner++)
                {
                    if (arr[inner]<arr[outer])
                    {
                        min = inner;
                    }
                    temp = arr[outer];
                    arr[inner] = arr[min];
                    arr[min] = temp;

                    Console.WriteLine("");
                    this.DisplayElements();
                }
            }
        }
    }
}
