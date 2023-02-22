namespace Lesson8HomeWork
{
    internal class Rectangle : Figure
    {
        public Rectangle(int SideA, int SideB)
        {
            this.SideA = SideA;
            this.SideB = SideB;
        }

        public  double CalcArea()
        { return SideA * SideB; }
        public  double CalcPerimeter() 
        { return (SideA + SideB) * 2; }
    }
}
