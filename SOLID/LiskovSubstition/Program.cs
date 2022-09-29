namespace LiskovSubstition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Bir sınıftan (A) başka bir sınıf (B) türetilmiş ise; A yerine B ya da B yerine A kullanılabılir olmalıdır.
             *  
             */

        }

        void SaveDocument(IRecordable document)
        {
            document.Save();
        }

        public interface IRecordable
        {
            void Save();
        }
        public class Document
        {
            public void Open() { }
            public void Close() { }

            public string Owner { get; set; }
        }

        public class PdfDocument : Document
        {

        }

        public class ExcelDocument : Document, IRecordable
        {
            public void Save()
            {

            }
        }
    }
}