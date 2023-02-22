namespace Lesson8HomeWork
{
    internal class Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Radius { get; set; }

        public  double CalcArea() { return 0; }
        public  double CalcPerimeter() { return 0; }
        public static void ShowSumPerimeters(params double[] Perimeters)
        {
            double result = 0;
            foreach (var item in Perimeters)
            {
                result += item;
            }
            Console.WriteLine($"Сумма периметров всех фигур массива равна {result}");
        }
    }
}
