namespace PracticeProblems3B.Interface
{
    class Rectangle : IResizable
    {
        public void Area()
        {
            Console.WriteLine("Enter width");
            int Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter heihgt");
            int Height = Convert.ToInt32(Console.ReadLine());
            if (Width < 0 && Height < 0)
            {
                Console.WriteLine("Width must +ve");
                Console.WriteLine("Hieght must +ve");
            }
            else
            {
                double area = Width * Height;
                Console.WriteLine("Area of Rectangle " + area);
            }
        }
    }
}
