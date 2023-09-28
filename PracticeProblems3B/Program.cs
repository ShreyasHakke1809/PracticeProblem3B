using PracticeProblems3B.AccessModifiers;
using PracticeProblems3B.Constructor;
using Rectangle = PracticeProblems3B.Interface.Rectangle;

namespace PracticeProblems3B
{
    class Program : Modifiers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n1.Defualt Constructor\n2.Parameterized Constructor\n3.Copy Constructor\n4.Static Constructor" +
                "\n5.Interface\n6.Access Modifiers\n7.Exit");
            bool loopAgain = true;
            while (loopAgain)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        DefualtConstructor def = new DefualtConstructor();
                        break;
                    case 2:
                        ParameterizedConstructor parameterized = new ParameterizedConstructor("Shreyas", 23);
                        break;
                    case 3:
                        CopyConstructor copyConstructor = new CopyConstructor(10);
                        CopyConstructor copy = new CopyConstructor(copyConstructor);
                        copy.Display();
                        break;
                    case 4:
                        StaticConstructor staticConstructor = new StaticConstructor();
                        staticConstructor.Display();
                        break;
                    case 5:
                        Rectangle rectangle = new Rectangle();
                        rectangle.Area();
                        break;
                    case 6:
                        Modifiers modifiers = new Modifiers();
                        modifiers.Test1();
                        //modifiers.Test2();
                        modifiers.Test3();
                        modifiers.Test5();

                        Program program = new Program();
                        program.Test4();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    case 8:
                        loopAgain = false;
                        break;
                }
            }
        }
    }
}