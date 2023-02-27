namespace Lesson8HomeWork
{
    internal class Circle : Figure
    {
        public Circle(double radius) 
        { this.radius = radius; }

        public  double CalcArea()
        { return Math.PI * Math.Pow(radius, 2); }
        public  double CalcPerimeter() 
        { return Math.PI * radius * 2; }
    }
}
