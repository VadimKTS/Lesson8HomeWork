namespace Lesson8HomeWork
{
    internal class Figure
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }
        public double radius { get; set; }

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
