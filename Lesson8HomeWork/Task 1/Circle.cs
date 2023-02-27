namespace Lesson8HomeWork.Task_1
{
    internal class Circle : Figure
    {
        public Circle(double radius) 
        { Radius = radius; }

        public  double CalcArea()
        { return Math.PI * Math.Pow(Radius, 2); }
        public  double CalcPerimeter() 
        { return Math.PI * Radius * 2; }
    }
}
