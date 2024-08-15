using Demo.Interfaces;
using System.Reflection;

namespace Demo
{
    internal class Program
    {
        #region Interface Ex 01
        //public static void Print10NumbersFromSeries(ISeries series)
        //{

        //    if (series is not null) { 
        //        for (int i = 0; i < 10; i++)
        //        {
        //            System.Console.WriteLine(series.Current);
        //            series.GetNext();
        //        }
        //        series.Reset();
        //    }
        //} 
        #endregion

        static void Main(string[] args)
        {
            #region Interface

            //IMyType myType = new IMyType(); // invalid because its not implmented

            //IMyType myType;
            // you can create a reference but not an object 
            // CLR will allocated 4 bytes for reference "myType"
            // references myType refer to null
            // reference myType can refer to an object from class or struct implment interface

            //myType.Id = 20; // invalid  -> myType refer to null
            //myType.MyFun(20); // invalid -> myType refer to null
            // myType.print(); // invalid -> myType refer to null

            //MyType myType01 = new MyType();

            //myType01.Id = 30;
            //myType01.MyFun(100);

            //myType01.print(); // invalid

            //IMyType myType2 = new MyType();
            //myType2.Id = 30;
            //myType2.MyFun(100); // valid because of the inteface reference 
            //myType2.print(); 

            #endregion

            #region Interface Ex 01

            //SeriesByTwo seriesByTwo = new SeriesByTwo();

            //Print10NumbersFromSeries(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();

            //Print10NumbersFromSeries(seriesByThree);
            //// 0 3 6 9 12 15 18 21 24 27

            //SeriesByFour seriesByFour = new SeriesByFour();

            // Print10NumbersFromSeries(seriesByFour); // invalid

            //ISeries series = seriesByFour;
            //series.Reset();
            #endregion

            #region Shallow Copy & Deep Copy

            #region Array of Value Type
            //int[] Arr01 = { 1, 2, 3 };

            //int[] Arr02 = new int[3]; // {0 ,0 ,0} n

            //Console.Write("Hash code of arr 1 :");
            //Console.WriteLine(Arr01.GetHashCode());

            //Console.Write("Hash code of arr 2 :");
            //Console.WriteLine(Arr02.GetHashCode());

            #region SHallow Copy at the stack
            //Arr02 = Arr01; // Shallow Copy [in the stack]
            //               // References [Arr01, Arr02] => Same Object

            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine(Arr02.GetHashCode());
            //Console.WriteLine(Arr01.GetHashCode());

            //Arr02[0] = 100;
            //Console.WriteLine($"Arr01[0] =  {Arr02[0]}"); // 100
            //Console.WriteLine($"Arr02[0] =  {Arr01[0]}"); // 100 
            #endregion


            #region Deep Copy [Heap]
            //Arr02 = (int[]) Arr01.Clone();
            //// Clone => Deep Copy
            //// deep copy occur at heap 
            //// creates a new object with different and new identity 
            //// That object will have the same object state [Data] of the caller object [Arr01]
            //// Return an Object

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine(Arr02.GetHashCode());
            //Console.WriteLine(Arr01.GetHashCode());

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            //Arr01[0] = 100;
            //Console.WriteLine("After Arr01[0] = 100");
            //Console.WriteLine($"Arr01[0] {Arr01[0]}"); // 100
            //Console.WriteLine($"Arr02[0] {Arr02[0]}"); // still 1


            #endregion


            #endregion

            #region Array of Reference Type

            #endregion

            #endregion

        }
    }
}
