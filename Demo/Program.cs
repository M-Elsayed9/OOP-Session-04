using Demo.Interfaces;

namespace Demo
{
    internal class Program
    {
        public static void Print10NumbersFromSeries(ISeries series)
        {

            if (series is not null) { 
                for (int i = 0; i < 10; i++)
                {
                    System.Console.WriteLine(series.Current);
                    series.GetNext();
                }
                series.Reset();
            }
        }

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

            #region Interface Ex 02

            SeriesByTwo seriesByTwo = new SeriesByTwo();

            Print10NumbersFromSeries(seriesByTwo);

            SeriesByThree seriesByThree = new SeriesByThree();

            Print10NumbersFromSeries(seriesByThree);
            // 0 3 6 9 12 15 18 21 24 27

            SeriesByFour seriesByFour = new SeriesByFour();

            // Print10NumbersFromSeries(seriesByFour); // invalid

            ISeries series = seriesByFour;
            series.Reset(); 
            #endregion

        }
    }
}
