using System.Diagnostics.Metrics;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo03ADV
{
    #region DelegateEx02

    // class
    // interface	
    //	enum	
    // struct	
    // delegate	
    // Step	01: Create NEW Datatype (Delegate)	

    public delegate int StringFuncDelegate(string s);
    // NEW Delegate(Class): Reference (Pointer) Can Refer To Function or More (Pointer Of	
    // These Function Must Be Have The Same Signature Of The Delegate: int(string)	
    // Regardless Function Name, Parameters Names Or, Access Modifiers	 
    #endregion

    internal class program
    {

        #region EX03
        public static List<int> FindElements(List<int> list, ConditionFuncDelegate reference)
        {
            List<int> Result = new List<int>();
            if (list?.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (reference.Invoke(list[i]))
                        Result.Add(list[i]);
                }
                return Result;
            }
        }

        //public static List<int> FindDivisableBy4Numbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (CondittonsFuntions.CheckDivisableBy4(list[i])))
        //                Result.Add(list[i]);
        //        }
        //        return Result;
        //    }
        //}


        //public static List<int> FindOddNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (CondittonsFuntions.CheckOdd(list[i]))
        //                Result.Add(list[i]);
        //        }
        //        return Result;
        //    }
        //}


        //public static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (CondittonsFuntions.CheckEven(list[i]))
        //                Result.Add(list[i]);
        //        }
        //        return Result;
        //    }
        //} 
        #endregion
        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write(value: $"{item} ");
            }
            Console.WriteLine();
        }
        public static void PrintArray<T>(T[] values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write(value: $"{item} ");
            }
            Console.WriteLine();
        }


        static void main()
        {
            #region Delegate Overview
            // Delegate : C# Feature	
            // C# Pure OOP	
            // Functional Programming	
            // Event-Driven Programming	
            // Java : Pure OOP	
            // DP :	 
            #endregion

            #region Delegate Ex01
            StringFuncDelegate X;
            X = StringFunctions.GetCountOfUpperCaseChars;
            //X.	

            StringFuncDelegate X = StringFunctions.GetCountOfUpperCaseChars; // Syntax Sugar	
            X += StringFunctions.GetCountOfLowerCaseChars;
            //int Count = X.Invoke("Hello World" )

            int Count = X("Hello World");
            Console WriteLine(Count);


            int Count = X.Invoke("Hello World");
            Console WriteLine(Count);
            #endregion

            #region Ex02
            int[] Numbers = { 9, 8, 7, 1, 2, 3, 6, 5, 4 };
            PrintArray(Numbers);
            //SortingAlgorithms. BubbleSortAscending (Numbers); // Sorting Ascending 
            ////SortingAlgorithms.BubbleSortDescending (Numbers); // Sorting Descending 


            SortingFuncDelegate X = SortingConditions.CompareGtr;

            SortingAlgorithms.BubbleSort(Numbers, X); // Sorting Ascending 
                                                      //SortingAlgorithms.BubbleSortDescending (Numbers); // Sorting Descending 


            PrintArray(Numbers);
            #endregion

            #region Delegate Ex03
            //List<int> Numbers = Enumerable.Range( 1, count: 100).ToList();
            //List<int> OddNumbers = FindOddNumbers(Numbers);
            //List<int> EvenNumbers = FindEvenNumbers(Numbers);

            PrintList(EvenNumbers);
            PrintList(OddNumbers);
            PrintList(FindDivisableBy4Numbers);

            List<int> OddNumbers FindElements(Numbers, Condittons Funtions.Check0dd);
            List<int> EvenNumbers = FindElements(Numbers, Condittons Funtions.CheckEven);
            List<int> DivisableBy4Numbers = FindElements(Numbers, CondittonsFuntions.CheckDivisableBy4);

            #endregion

            #region Built-in Delegate 

            //            // Built-in Delegate 
            //            // Predicate, Func, Action 
            //            // Predicate 
            //            ConditionFuncDelegate<int> X = CondittonsFuntions.CheckEven;

            //            Predicate<int> predicate = CondittonsFuntions.CheckEven;
            //            bool r = predicate.Invoke(1);
            //            Console.WriteLine(r);

            //            Func<int> func = Fun01;
            //            Func<int, string> func1 = Fun02;

            //            //Func<int, bool> predicate = Condittons Funtions.CheckEven; 

            //            Action string> action = Print;

            ////action.Invoke(); 
            ////action(); 


            //public static void Print(string X)
            //        {
            //            Console.WriteLine(X);
            //        }
            //        public static int Fun01()
            //        {
            //            return 1;
            //        }

            //        public static int Fun02()
            //        {
            //            return 1;
            //        } 
            #endregion

            #region Lambda Expression And Anonymous Method 

            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 9, 10 };

            // Anonymous Method 
            // C# 2.0 2005 
            Func<int, bool> func delegate (int X) { return X % 2 == 0; }; // Апопутous Method 


            //FindElements (Numbers, func); 
            FindElements(Numbers, delegate (int X) { return X % 2 == 0; });


            // Lambda Expression 
            // C# 3.0 2007 

            Func<int, bool> func = X => X % 2 == 0; // Lambda Expression 


            //FindElements (Numbers, func); 
            //FindElements (Numbers, delegate (int x) { return X % 2 == 0; }); 
            FindElements(Numbers, N = N % 2 == 0);
            FindElements(Numbers, N => N % 2 != 0);

            Enumerable.Where(Numbers, Condittons Funtions.CheckOdd);
            Enumerable.Where(Numbers, delegate (int N) { return N % 2 I = theta; 3 )
Enumerable.Where(Numbers, (int N) { return N % 2 != 0; });
            #endregion

            #region C# Keyword 

            // C# Keyword 
            // C# 3.0 
            // var 
            var X = "Hewllo";
            //X = 12; 
            var predicate = CondittonsFuntions.CheckDivisableBy4;

            #endregion

            #region FP Feature 
            //var action = Fun010; 
            //action.Invoke(); 
            //            Fun01()();
            //            public static Action Fun01()
            ////Action action = Print; 
            ////Action action delegate () { Console.WriteLine("Hello World"); }; 
            //Action action = () => Console.WriteLine(value: "Hello World"); 
            //return action; 
            //}

            //} 
            #endregion
        }
    }
}