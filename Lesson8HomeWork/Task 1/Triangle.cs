namespace Lesson8HomeWork.Task_1
{
    internal class Triangle : Figure
    {
        public Triangle(int sideA, int sideB, int sideC)
        {   
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public  double CalcArea()
        {
            double p = CalcPerimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public  double CalcPerimeter()
        { return SideA + SideB + SideC; }
    }
}
