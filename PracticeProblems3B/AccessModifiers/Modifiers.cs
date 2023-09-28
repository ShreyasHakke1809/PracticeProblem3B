namespace PracticeProblems3B.AccessModifiers
{
    //we use only internal and public with class
    public class Modifiers
    {
        public void Test1()
        {
            Console.WriteLine("Public access modifier");
        }
        //access within class
        private void Test2()
        {
            Console.WriteLine("Private access modifier");
        }
        //access within solution 
        internal void Test3()
        {
            Console.WriteLine("Internal access modifier");
        }
        //access within class as well as derived class 
        protected void Test4()
        {
            Console.WriteLine("Protected access modifier");
        }
        //access within class as well as derived class and another solution also
        protected internal void Test5()
        {
            Console.WriteLine("Protected internal access modifier");
        }
    }
}
