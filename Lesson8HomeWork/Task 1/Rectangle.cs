namespace Lesson8HomeWork.Task_1
{
    internal class Rectangle : Figure
    {
        public Rectangle(int sideA, int sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public  double CalcArea()
        { return SideA * SideB; }
        public  double CalcPerimeter() 
        { return (SideA + SideB) * 2; }
    }
}
