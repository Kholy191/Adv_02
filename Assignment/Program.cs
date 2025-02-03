﻿using System.Collections;

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

            #region Q2

            //List<int> ints = new List<int>() { 4, 5, 1, 3, 6, 8, 22 };

            //List<int> EvenArr = new List<int>(Helper.EvenList(ints));

            //for (int i = 0; i < EvenArr.Count; i++)
            //    Console.WriteLine(EvenArr[i]);

            #endregion

            #region Q3

            //FixedSizeList<int> List = new FixedSizeList<int>(5);
            //List.Add(1);
            //List.Add(2);
            //List.Add(3);
            //List.Add(4);
            //List.Add(5);

            //Console.WriteLine(List.GetMethod(0));
            //Console.WriteLine(List.GetMethod(1));

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

        #region Q2 You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

        public static List<int> EvenList(List<int> OrginalList)
        {
            List<int> EvenArr = new List<int>(OrginalList.Count);
            for (int i = 0; i < OrginalList.Count; i++)
            {
                if ((OrginalList[i] % 2) == 0) { EvenArr.Add(OrginalList[i]); }
            }
            return EvenArr;
        }

        #endregion

    }

    #region Q3 implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
    public class FixedSizeList<T>
    {
        T[]? ListArr;
        int Count;
        int Capacity;
        public FixedSizeList(int capacity)
        {
            Capacity = capacity;
            ListArr = new T[Capacity];
        }

        public void Add(T item)
        {
            if (Count == Capacity)
            {
                throw new ArgumentException("the list is already full.");
            }
            else
            {
                if (item != null)
                {
                    ListArr![Count] = item;
                    Count++;
                }
            }
        }

        public T GetMethod(int index)
        {
            
            if (index > (Count-1) || index < 0)
            {
                throw new ArgumentException("Invalid index or List is empty");
            }
            return ListArr![index]; ;
        }
    }

    #endregion

}
