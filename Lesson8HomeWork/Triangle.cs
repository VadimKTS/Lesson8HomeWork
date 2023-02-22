namespace Lesson8HomeWork
{
    internal class Triangle : Figure
    {
        public Triangle(int SideA, int SideB, int SideC)
        {   
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
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
