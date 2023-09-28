namespace PracticeProblems3B.Constructor
{
    internal class StaticConstructor
    {
        public static int MaxConnections { get; private set; }
        static StaticConstructor()
        {
            MaxConnections = 100;
        }
        public void Display()
        {
            Console.WriteLine(MaxConnections);
        }

    }
}
