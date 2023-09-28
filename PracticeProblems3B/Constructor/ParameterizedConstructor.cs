namespace PracticeProblems3B.Constructor
{
    internal class ParameterizedConstructor
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ParameterizedConstructor(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
