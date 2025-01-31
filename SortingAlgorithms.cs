using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo03ADV
{

    //public delegate bool SortingFuncDelegate(int A, int B);
    //public delegate bool SortingFuncDelegateV2(string A, string B);

    // Generic Version 
    public delegate bool SortingFuncDelegate<T>(T A, T B);

    internal class SortingAlgorithms

    {


        public static void BubbleSort<T>(<T>[] Arr, SortingFuncDelegate reference)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - 1 - 1; j++)
                    {
                        if (reference.Invoke(Arr[j], Arr[j + 1]))
                            SWAP(ref Arr[j], ref Arr[j + 1]);


                    }
                }
            }
        }


        //public static void BubbleSort(string[] Arr, SortingFuncDelegateV2 reference)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - 1 - 1; j++)
        //            {
        //                if (reference.Invoke(Arr[j], Arr[j + 1])) SWAP(ref Arr[j], ref Arr[j + 1]);


        //            }
        //        }
        //    }
        //}

        //public static void BubbleSort(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (SortingConditions.CompareGtr(Arr[j], Arr[j + 1]))// SWAP	
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}



        //public static void BubbleSortDescending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - 1 - 1; j++)
        //            {
        //                if (SortingConditions.CompareLess(Arr[j], Arr[j + 1]))
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //            }
        //        }
        //    }
        //}



        private static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;

        }


        //private static void SWAP(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;

        //}

        //private static void SWAP(ref string X, ref string Y)
        //{
        //    string Temp = X;
        //    X = Y;
        //    Y = Temp;

        //}

    }
}