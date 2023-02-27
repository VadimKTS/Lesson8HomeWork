namespace Lesson8HomeWork.Task_3
{
    public abstract class Document : IOperationsWithDocuments
    {
        public int documentNumber;
        public DateTime documentDate;

        public Document()
        {
            documentDate = DateTime.Now;
        }


        public int DocumentNumber
        {
            get { return documentNumber; }
            set { documentNumber = value; }
        }
        public DateTime DocumentDate
        {
            get { return documentDate; }
            set { documentDate = value; }
        }

        public abstract void CreateDocument();
        public abstract void ShowInfo(); 
    }
}
