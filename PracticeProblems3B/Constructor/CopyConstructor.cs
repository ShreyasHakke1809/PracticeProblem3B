namespace PracticeProblems3B.Constructor
{
    internal class CopyConstructor
    {
        int x;

        // Copy constructor
        public CopyConstructor(int y)
        {
            x = y;
        }
        public CopyConstructor(CopyConstructor other)
        {
            x = other.x;
        }
        public void Display()
        {
            Console.WriteLine(x);
        }
    }
}
