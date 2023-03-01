namespace Lesson8HomeWork.Task_3
{
    internal class FinancialInvoice : Document
    {
        public decimal monthlyTotal;
        public int departmentCode;


        public FinancialInvoice() { }
        public FinancialInvoice(int documentNumber, decimal monthlyTotal, int departmentCode)
        {
            this.documentNumber = documentNumber;
            this.documentDate = DateTime.Now;
            this.monthlyTotal = monthlyTotal;
            this.departmentCode = departmentCode;
        }

        public decimal MonthlyTotal
        {
            get { return monthlyTotal; }
            set { monthlyTotal = value; }
        }
        public int DepartmentCode
        {
            get { return departmentCode; }
            set { departmentCode = value; }
        }

        public override void CreateDocument()
        {
            Console.WriteLine("\n-----Финансовая накладная-----\n-----Введите, пожалуйста...-----");
            Console.Write("Номер документа: ");
            DocumentNumber = int.Parse(Console.ReadLine());
            Console.Write("Итоговая сумма за месяц: ");
            MonthlyTotal = Decimal.Parse(Console.ReadLine());
            Console.Write("Код департамента: ");
            DepartmentCode = int.Parse(Console.ReadLine());

        }

        public override void ShowInfo()
        {
            Console.WriteLine("\n-----Финансовая накладная-----");
            Console.WriteLine($"Номер документа: {DocumentNumber}\nДата документа: {DocumentDate.ToString("dd-MM-yyyy HH:mm")}");
            Console.WriteLine($"Итоговая сумма за месяц: {MonthlyTotal}\nКод департамента: {DepartmentCode} ");
        }
    }
}
