namespace Lesson8HomeWork.Task_3
{
    internal class ContractWithAnEmployee : Document, IOperationsWithDocuments
    {
        public string employeeName;
        public DateOnly contractEndDate;

        public ContractWithAnEmployee() { }
        public ContractWithAnEmployee( int documentNumber, string employeeName, DateOnly contractEndDate)
        {
            this.documentNumber = documentNumber;
            this.documentDate = DateTime.Now;
            this.employeeName = employeeName;
            this.contractEndDate = contractEndDate;
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public DateOnly ContractEndDate
        {
            get { return contractEndDate; }
            set { contractEndDate = value; }
        }

        public override void CreateDocument()
        {
            Console.WriteLine("\n-----Контракт с сотрудником-----\n-----Введите, пожалуйста...-----");
            Console.Write("Номер документа: ");
            DocumentNumber = int.Parse(Console.ReadLine());
            Console.Write("Имя Сотрудника: ");
            EmployeeName = Console.ReadLine();
            Console.Write("Дата окончания контракта (YYYY,MM,DD): ");
            SetDateAgain:
            string date = Console.ReadLine();
            if (DateOnly.TryParse(date, out DateOnly result))  { ContractEndDate = result; }
            else 
            {
                Console.WriteLine("Введите дату окончания контракта в соответствии с форматом!!! (YYYY,MM,DD):");
                goto SetDateAgain;
            }

        }

        public override void ShowInfo()
        {
            Console.WriteLine("\n-----Контракт с сотрудником-----");
            Console.WriteLine($"Номер документа: {DocumentNumber}\nДата документа: {DocumentDate.ToString("dd-MM-yyyy HH:mm")}");
            Console.WriteLine($"Имя Сотрудника: {EmployeeName}\nДата окончания контракта: {ContractEndDate} ");
        }
    }
}
