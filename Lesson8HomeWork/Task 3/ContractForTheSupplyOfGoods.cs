namespace Lesson8HomeWork.Task_3
{
    internal class ContractForTheSupplyOfGoods : Document
    {
        public decimal quantityOfGoods;
        public string goodsType;

        public ContractForTheSupplyOfGoods() { }
        public ContractForTheSupplyOfGoods(int documentNumber, decimal quantityOfGoods, string goodsType)
        {
            this.documentNumber = documentNumber;
            this.documentDate = DateTime.Now;
            this.quantityOfGoods = quantityOfGoods;
            this.goodsType = goodsType;
        }
        public decimal QuantityOfGoods
        {
            get { return quantityOfGoods; }
            set { quantityOfGoods = value; }
        }
        public string GoodsType
        {
            get { return goodsType; }
            set { goodsType = value; }
        }

        public override void CreateDocument()
        {
            Console.WriteLine("\n-----Контракт на поставку товара-----\n-----Введите, пожалуйста...-----");
            Console.Write("Номер документа: ");
            DocumentNumber = int.Parse(Console.ReadLine());
            Console.Write("Тип товара: ");
            GoodsType = Console.ReadLine();
            Console.Write("Количество товара: ");
            QuantityOfGoods = decimal.Parse(Console.ReadLine());
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine("\n-----Контракт на поставку товара-----");
            Console.WriteLine($"Номер документа: {DocumentNumber}\nДата документа: {DocumentDate.ToString("dd-MM-yyyy HH:mm")}");
            Console.WriteLine($"Тип товара: {GoodsType}\nКоличество товара: {QuantityOfGoods} ");
        }
    }
}
