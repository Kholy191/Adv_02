using System.Collections;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //ArrayList arrayList = new ArrayList(5) { 1, 2, 3, 4, 5 };
            //Helper.ReverseList(arrayList);

            //for (int i = 0; i < arrayList.Count; i++)
            //    Console.WriteLine(arrayList[i]);

            #endregion


        }
    }



    public static class Helper
    {
        #region Q1 You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
        public static void ReverseList(ArrayList Arr)
        {
            if (Arr != null && Arr.Count > 0)
            {
                int Count = Arr.Count / 2;
                for (int i = 0; i < Count; i++)
                {
                    object? Temp = (Arr[i]);
                    Arr[i] = Arr[Arr.Count - 1 - i];
                    Arr[Arr.Count - 1 - i] = Temp;

                }
            }
        }

        #endregion


    }


}
