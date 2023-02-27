namespace Lesson8HomeWork
{
    internal class Rectangle : Figure
    {
        public Rectangle(int sideA, int sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public  double CalcArea()
        { return sideA * sideB; }
        public  double CalcPerimeter() 
        { return (sideA + sideB) * 2; }
    }
}
