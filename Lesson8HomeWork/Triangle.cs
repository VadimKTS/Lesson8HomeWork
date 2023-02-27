namespace Lesson8HomeWork
{
    internal class Triangle : Figure
    {
        public Triangle(int sideA, int sideB, int sideC)
        {   
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public  double CalcArea()
        {
            double p = CalcPerimeter() / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
        public  double CalcPerimeter()
        { return sideA + sideB + sideC; }
    }
}
