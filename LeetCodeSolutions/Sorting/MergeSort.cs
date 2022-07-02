using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Sorting
{
    public class MergeSort
    {
        public void Sort(ref int[] i_Arr, int i_Left, int i_Right)
        {
            if (i_Left < i_Right)
            {
                int mid = (i_Right - i_Left) / 2 + i_Left;

                Sort(ref i_Arr, i_Left, mid);
                Sort(ref i_Arr, mid + 1, i_Right);

                merge(ref i_Arr, i_Left, mid, i_Right);
            }
        }

        private void merge(ref int[] i_Arr, int i_Left, int i_Mid, int i_Right)
        {    // Merges two subarrays of []arr.
             // First subarray is arr[l..m]
             // Second subarray is arr[m+1..r]
             // Find sizes of two
             // subarrays to be merged
                int n1 = i_Mid - i_Left + 1;
                int n2 = i_Right - i_Mid;

                // Create temp arrays
                int[] L = new int[n1];
                int[] R = new int[n2];
                int i, j;

                // Copy data to temp arrays
                for (i = 0; i < n1; ++i)
                    L[i] = i_Arr[i_Left + i];
                for (j = 0; j < n2; ++j)
                    R[j] = i_Arr[i_Mid + 1 + j];

                // Merge the temp arrays

                // Initial indexes of first
                // and second subarrays
                i = 0;
                j = 0;

                // Initial index of merged
                // subarray array
                int k = i_Left;
                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        i_Arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        i_Arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                // Copy remaining elements
                // of L[] if any
                while (i < n1)
                {
                    i_Arr[k] = L[i];
                    i++;
                    k++;
                }

                // Copy remaining elements
                // of R[] if any
                while (j < n2)
                {
                    i_Arr[k] = R[j];
                    j++;
                    k++;
                }

                // Main function that
                // sorts arr[l..r] using
                // merge()
            }
        }
    }
