using System;
using System.Collections.Generic;

namespace CSharpArrangeNumbersWithoutUsingSort
{
    class Program
    {

        //Arrange Array without using sort function
        static void Main(string[] args)
        {
            //List<int> li = new List<int>();
            List<int> li = new List<int>();
            li.Add(4);
            li.Add(1);
            li.Add(3);
            li.Add(2);

            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

            li.MySortFunction();

            Console.WriteLine("After sorting successfully.");

            foreach(var item in li)
            {
                Console.WriteLine(item);
            }

        }
    }

    public static class MyListFuncton
    {
        public static void MySortFunction(this List<int> li)
        {
            int temp = 0;
            for(int i=0; i<li.Count; i++)
            {
                for (int j = 0; j < li.Count; j++)
                {
                    if(li[i] < li[j])
                    {
                        //swap
                        //if i is less than j then swap simple rule

                        temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;

                    }
                }
            }    
        }
    }
}
