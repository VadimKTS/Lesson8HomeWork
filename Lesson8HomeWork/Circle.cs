namespace Lesson8HomeWork
{
    internal class Circle : Figure
    {
        public Circle(double Radius) 
        { this.Radius = Radius; }

        public  double CalcArea()
        { return Math.PI * Math.Pow(Radius, 2); }
        public  double CalcPerimeter() 
        { return Math.PI * Radius * 2; }
    }
}
