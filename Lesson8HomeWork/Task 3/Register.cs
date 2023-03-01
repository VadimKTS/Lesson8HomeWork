namespace Lesson8HomeWork.Task_3
{
    public class Register
    {
        private int count; 
        
        public Document[] documents = new Document[10];
        int docType;

        public Register()  
        { this.count = 0; }

        private int Count
        {
            get { return count; }
            set { count = value; }
        }

        public void SaveDocumentToRegister(Document document)
        {
            if (Count >= documents.Length - 1)
            {
                Console.WriteLine("Массив заполнен!!!!!!!!!!");
                documents[Count] = document;
                Console.WriteLine($"Документ №{document.documentNumber} перезаписан!!!");
                count = 0;
            }
            else
            {
                if (document.documentNumber == 0 && documents[Count] == null)
                {
                    document.CreateDocument();
                    documents[Count] = document;
                    Console.WriteLine($"Документ №{document.documentNumber} сохранен");
                    Count++;
                }
                else if (documents[Count] != null)
                {
                    documents[Count] = document;
                    Console.WriteLine($"Документ №{document.documentNumber} перезаписан!");
                    Count++;
                }
                else
                {
                    documents[Count] = document;
                    Console.WriteLine($"Документ №{document.documentNumber} сохранен");
                    Count++;
                }
            }
        }
                
        public void ShowDocumentInfo(Document document) 
        { 
            document.ShowInfo(); 
        }
    }
}
