
using Lesson8HomeWork.Task_3;

namespace Lesson8HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Task 1 --------------------------------------------------------------------------------

            //var triangle = new Triangle(3, 5, 2);
            //Console.WriteLine($"Площадь = {triangle.CalcArea()}\nПериметр = {triangle.CalcPerimeter()}");

            //var triangle2 = new Triangle(2, 4, 3);
            //Console.WriteLine($"Площадь = {triangle2.CalcArea()}\nПериметр = {triangle2.CalcPerimeter()}");

            //var circle = new Circle(3);
            //Console.WriteLine($"Площадь = {circle.CalcArea()}\nПериметр = {circle.CalcPerimeter()}");

            //var rectangle = new Rectangle(3, 5);
            //Console.WriteLine($"Площадь = {rectangle.CalcArea()}\nПериметр = {rectangle.CalcPerimeter()}");

            //var rectangle2 = new Rectangle(7, 4);
            //Console.WriteLine($"Площадь = {rectangle2.CalcArea()}\nПериметр = {rectangle2.CalcPerimeter()}");


            //double[] Perimeters = new[] { triangle.CalcPerimeter(), triangle2.CalcPerimeter(), circle.CalcPerimeter(), rectangle.CalcPerimeter(), rectangle2.CalcPerimeter() };
            //Figure.ShowSumPerimeters(Perimeters);





            //// Task 2 --------------------------------------------------------------------------------

            //var director = new Director();
            //director.ShowPosition();

            //var worker = new Worker();
            //worker.ShowPosition();

            //var accountant = new Accountant();
            //accountant.ShowPosition();



            //// Task 3 --------------------------------------------------------------------------------
            var registr = new Register();
            
            var doc1 = new ContractForTheSupplyOfGoods();
            var doc2 = new ContractWithAnEmployee();
            var doc3 = new FinancialInvoice();
            var doc4 = new ContractForTheSupplyOfGoods(4,155, "Арбузы");
            var doc5 = new ContractWithAnEmployee(5,"Джон",new DateOnly(2025,11,22));
            var doc6 = new FinancialInvoice(6,65466,6);
            var doc7 = new FinancialInvoice(7, 65466, 6);
            var doc8 = new FinancialInvoice(8, 65466, 6);
            var doc9 = new FinancialInvoice(9, 46, 6);
            var doc10 = new FinancialInvoice(10, 65, 6);
            var doc11 = new FinancialInvoice(11, 0, 6);

            registr.SaveDocumentToRegister(doc1);
            registr.SaveDocumentToRegister(doc2);
            registr.SaveDocumentToRegister(doc3);
            registr.SaveDocumentToRegister(doc4);
            registr.SaveDocumentToRegister(doc5);
            registr.SaveDocumentToRegister(doc6);
            registr.SaveDocumentToRegister(doc7);
            registr.SaveDocumentToRegister(doc8);
            registr.SaveDocumentToRegister(doc9);
            registr.SaveDocumentToRegister(doc10);
            registr.SaveDocumentToRegister(doc11);

            //for (int i = 0; i < 10; i++)
            //{
            //    registr.ShowDocumentInfo(i);
            //}

            registr.ShowDocumentInfo(doc1);
            registr.ShowDocumentInfo(doc2);
            registr.ShowDocumentInfo(doc3);
            registr.ShowDocumentInfo(doc4);
            registr.ShowDocumentInfo(doc5);
            registr.ShowDocumentInfo(doc6);
            registr.ShowDocumentInfo(doc7);
            registr.ShowDocumentInfo(doc8);
            registr.ShowDocumentInfo(doc9);
            registr.ShowDocumentInfo(doc10);
            registr.ShowDocumentInfo(doc11);
        }
    }
}