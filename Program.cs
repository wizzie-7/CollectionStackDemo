using System;
using System.Collections;

namespace CollectionStackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDemo SD = new StackDemo();
            SD.StackMethod();
        }
    }
    public class StackDemo
    {
        public void StackMethod()
        {
            Stack S = new Stack();
            S.Push("VIVEK");
            S.Push("KRUNAL");
            S.Push("NIRBHAY");
            S.Push("ABHI");

            Console.WriteLine("Number of Valyes in stack :" + S.Count);

            Console.WriteLine("Values of Stack");
            IEnumerator IN = S.GetEnumerator();
            while (IN.MoveNext())
            {
                Console.WriteLine(IN.Current);
            }

            //for (var i = ""; i < s.count; i++)
            //{
            //    Console.WriteLine(i);
            //    in.movenext();
            //}

            Console.WriteLine( "Deleted Element :",S.Pop());

            Console.WriteLine("Number of Values in stack after deleting :" + S.Count);

            Console.WriteLine("Values of Stack");
            IEnumerator INT = S.GetEnumerator();
            while (INT.MoveNext())
            {
                Console.WriteLine(INT.Current);
            }

            //S.Peek();
            Console.WriteLine("Values in stack after Peeking :" + S.Peek());

            //Console.WriteLine("Values of Stack");
            //IEnumerator INE = S.GetEnumerator();
            //while (INE.MoveNext())
            //{
            //    Console.WriteLine(INE.Current);
            //}

        }
    }
}
