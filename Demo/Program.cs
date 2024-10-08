using Demo.IClonable_Interface;
using Demo.Interfaces;
using System.Reflection;
using System.Text;

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

        public static void SWAP(Employee emp1, Employee emp2)
        {
            Employee temp = new Employee(emp1);
            emp1 = new Employee(emp2);
            emp2 = new Employee(temp);
        }

        static void Main(string[] args)
        {
            #region Interface

            //IMyType myType = new IMyType(); // invalid because it's not implemented

            //IMyType myType;
            // you can create a reference but not an object 
            // CLR will allocate 4 bytes for reference "myType"
            // references myType refer to null
            // reference myType can refer to an object from class or struct implement interface

            //myType.Id = 20; // invalid  -> myType refer to null
            //myType.MyFun(20); // invalid -> myType refer to null
            // myType.print(); // invalid -> myType refer to null

            //MyType myType01 = new MyType();

            //myType01.Id = 30;
            //myType01.MyFun(100);

            //myType01.print(); // invalid

            //IMyType myType2 = new MyType();
            //myType2.Id = 30;
            //myType2.MyFun(100); // valid because of the interface reference 
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

            #region Shallow Copy at the stack
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

            #region Array of String [Immutable Type]

            //string[] Names01 = { "Omar", "Ahmed", "Mohamed" };
            //string[] Names02 = new string[1]; // {null}

            #region Shallow copy
            //Console.Write("Hash code of Names01: ");
            //Console.WriteLine(Names01.GetHashCode());

            //Console.Write("Hash code of Names02: ");
            //Console.WriteLine(Names02.GetHashCode());

            //Names02 = Names01; // Shallow Copy [in the stack]

            //Console.WriteLine("After Shallow Copy");
            //Console.Write("Hash code of Names01: ");
            //Console.WriteLine(Names01.GetHashCode());

            //Console.Write("Hash code of Names02: ");
            //Console.WriteLine(Names02.GetHashCode());

            //Names02[0] = "Aya";
            // both will be aya because string is immutable 
            #endregion

            #region Deep Copy

            //Names02 = (string[]) Names01.Clone();
            //// Clone => Deep Copy [in the heap]
            //// creates a new object with new and different identity
            //// That object will have the same object state [Data] of the caller object [Names01]
            //// Return an Object

            //Console.Write("Hash code of Names01: ");
            //Console.WriteLine(Names01.GetHashCode());

            //Console.Write("Hash code of Names02: ");
            //Console.WriteLine(Names02.GetHashCode());

            //Names02[0] = "Aya";
            //// Names01[0] = "Omar"

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine(Names01[0]);
            //Console.WriteLine(Names02[0]);


            #endregion

            #endregion

            #region Array of StringBuilder [Mutable Type]
            //StringBuilder[] Name01 = new StringBuilder[1];
            ////Name01[0].Append("Omar"); // invalid NullReferenceException

            //Name01[0] = new StringBuilder("Omar");

            //StringBuilder[] Name02 = new StringBuilder[1];
            #region Shallow Copy


            //Console.WriteLine("Hash code of Name01: ");
            //Console.WriteLine(Name01.GetHashCode());
            //Console.WriteLine("Hash code of Name02: ");
            //Console.WriteLine(Name02.GetHashCode());

            //Name02 = Name01; // Shallow Copy [in the stack]
            //// 2 references [Name01, Name02] => Same Object

            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine(Name01.GetHashCode());
            //Console.WriteLine(Name02.GetHashCode());

            //Name02[0].Append("Amr");
            //Console.WriteLine(Name01[0]); // OmarAmr
            //Console.WriteLine(Name02[0]); // OmarAmr 
            #endregion

            #region Deep Copy

            //Name02 = (StringBuilder[]) Name01.Clone(); // Deep Copy
            //// 2 references  [ Names01, Names02 ] => 2 different addresses

            //Console.WriteLine("Hash code of Name01: ");
            //Console.WriteLine(Name01.GetHashCode());
            //Console.WriteLine("Hash code of Name02: ");
            //Console.WriteLine(Name02.GetHashCode());

            //Console.WriteLine(Name01[0]); // Omar
            //Console.WriteLine(Name02[0]); // Omar

            //Name01[0].Append(" Ahmed");

            //Console.WriteLine("After Append Ahmed to Name01");
            //Console.WriteLine(Name01[0]); // Omar Ahmed
            //Console.WriteLine(Name02[0]); // Omar Ahmed


            #endregion

            #endregion

            #region IClonable Interface

            //Employee employee01 = new Employee { Id = 10, Name = "Aliaa", Salary = 9000 };
            //Employee employee02 = new Employee { Id = 20, Name = "Mona", Salary = 10000 };

            //Console.WriteLine($"Hash code of employee01: {employee01.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee01}");
            //Console.WriteLine($"Hash code of employee02: {employee02.GetHashCode()}");
            //Console.WriteLine($"Employee02 = {employee02}");
            // different hash code

            #region Shallow Copy and deep Copy

            #region Shallow Copy [Stack]
            //employee02 = employee01; // Shallow Copy [Stack]
            //// 2 references [employee01, employee02] => Same Object
            //// {10, Aliaa , 9000}

            //Console.WriteLine($"Hash code of employee01: {employee01.GetHashCode()}");
            //Console.WriteLine($"Hash code of employee02: {employee02.GetHashCode()}");

            //Console.WriteLine($"Employee01 = {employee01}");
            //Console.WriteLine($"Employee02 = {employee02}");

            //employee01.Name = "Reem";
            //employee02.Salary = 5000;
            //Console.WriteLine("After employee01.Name = Reem & employee02.Salary = 5000 ");
            //Console.WriteLine($"Employee01 = {employee01}");
            //Console.WriteLine($"Employee02 = {employee02}");

            #endregion

            #region Deep Copy
            //employee02 = (Employee)employee01.Clone(); // Deep Copy
            //// 2 references [employee01, employee02] => 2 different addresses
            //// 2 references refer to the different objects => different identity & different hashcode
            //// 2 references refer to objects that have the same state [Data]

            //Console.WriteLine($"Hash code of employee01: {employee01.GetHashCode()}");
            //Console.WriteLine($"Hash code of employee02: {employee02.GetHashCode()}");

            //Console.WriteLine($"Employee01 = {employee01}");
            //Console.WriteLine($"Employee02 = {employee02}");

            //employee01.Name = "Ali";
            //employee02.Salary = 5000;
            //Console.WriteLine("After employee01.Name = Ali & employee02.Salary = 5000 ");
            //Console.WriteLine($"Employee01 = {employee01}");
            //Console.WriteLine($"Employee02 = {employee02}");

            #endregion

            #endregion


            #region SWAP


            //Console.WriteLine("Before SWAP");
            //Console.WriteLine($"Employee01 = {employee01}");
            //Console.WriteLine($"Employee02 = {employee02}");

            //SWAP(employee01, employee02);
            //Console.WriteLine("After SWAP");
            //Console.WriteLine($"Employee01 = {employee01}");
            //Console.WriteLine($"Employee02 = {employee02}");

            // It works but didn't give the output required.
            #endregion

            #endregion

            #endregion

            #endregion

            #region Printing

            //PropertyInfo[] propertyInfos = typeof(Employee).GetProperties();
            //foreach (var propertyInfo in propertyInfos)
            //{
            //    Console.WriteLine($"{propertyInfo.Name}");
            //}

            //PropertyInfo propertyInfo1 = typeof(Employee).GetProperty("Id");

            //Console.WriteLine($"propertyInfo1.Name {propertyInfo1.Name}");
            //Console.WriteLine($"propertyInfo1.PropertyType {propertyInfo1.PropertyType}");

            //Employee employee03 = new Employee { Id = 30, Name = "Ahmad", Salary = 1000 };

            //Console.WriteLine($"employee03 {employee03}");
            #endregion

            #region Inheritance

            #region Test01
            //Circle c01 = new Circle();
            //c01.radius = 10;
            //c01.printCircleData(); 
            #endregion

            #region Test02
            //Rectangle r01 = new Rectangle();
            //r01.Width = 10;
            //r01.Height = 20;
            //r01.printRectData();
            //r01.ShapeColor = "Green";
            //r01.printShapeColor(); 
            #endregion

            #endregion

            #region Boxing

            //int x = 10;
            //object obj = x; // Boxing

            //Console.WriteLine(x);
            //Console.WriteLine(obj);
            //Console.WriteLine(obj.GetHashCode());

            //int x2 = (int) obj; // unboxing

            //Console.WriteLine(x2);

            #endregion
        }
    }
}
