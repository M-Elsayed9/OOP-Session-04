using System.Runtime.Intrinsics.X86;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1

            #region Question 1
            // what is the primary purpose of an interface in C#?

            //a) To provide a way to implement multiple inheritance
            //b) To define a blueprint for a class
            //c) To declare abstract methods and properties
            //d) To create instances of objects

            //b) To define a blueprint for a class
            #endregion

            #region Question 2
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            //b) protected
            //c) internal
            //d) public

            //a) private // because other classes that implment the interface wont be able to see it 

            #endregion

            #region Question 3
            //Question 3:
            //Can an interface contain fields in C#?
            //a) Yes
            //b) No
            //c) Only if they are static
            //d) Only if they are readonly 

            // b) No
            #endregion

            #region Question 4
            //Question 4:
            //In C#, can an interface inherit from another interface?
            //a) No, interfaces cannot inherit from each other
            //b) Yes, interfaces can inherit from multiple interfaces
            //c) Yes, but only if they have the same methods
            //d) Only if the interfaces are in the same namespace

            //b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            #region Quesiton 5
            //Question 5:
            //Which keyword is used to implement an interface in a class in C#?
            //a) inherit
            //b) use
            //c) extends
            //d) implements  

            // d) implements
            #endregion

            #region Question 6
            //Question 6:
            //Can an interface contain static methods in C#?
            //a) Yes
            //b) No
            //c) Only if the interface is sealed
            //d) Only if the methods are private 

            // b) Yes
            #endregion

            #region Question 7
            //Question 7:
            //In C#, can an interface have explicit access modifiers for its members?
            //a) Yes, for all members
            //b) No, all members are implicitly public
            //c) Yes, but only for abstract members
            //d) Only if the interface is sealed

            // b) No, all members are implicitly public
            #endregion

            #region Question 8
            //Question 8:
            //What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access
            //b) To provide a clear separation between interface and class members
            //c) To allow multiple classes to implement the same interface
            //d) To speed up method resolution 

            // b) To provide a clear separation between interface and class members
            #endregion


            #region Question 9
            //Question 9:
            //In C#, can an interface have a constructor?
            //a) Yes, but it must be private
            //b) No, interfaces cannot have constructors
            //c) Yes, but only if the interface is sealed
            //d) Only if the constructor is static 

            // b) No, interfaces cannot have constructors
            #endregion

            #region Question 10
            //Question 10:
            //How can a C# class implement multiple interfaces?
            //a) By using the "implements" keyword
            //b) By using the "extends" keyword
            //c) By separating interface names with commas
            //d) A class cannot implement multiple interfaces 

            // c) By separating interface names with commas
            #endregion


            #endregion
        }
    }
}
