using Demo.Interfaces;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface

            //IMyType myType = new IMyType(); // invalid because its not implmented

            IMyType myType;
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

            IMyType myType2 = new MyType();
            myType2.Id = 30;
            myType2.MyFun(100); // valid because of the inteface reference 
            myType2.print(); 

            #endregion
        }
    }
}
