namespace IntroOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Calisan calisan = new Calisan();
        }
    }

    public class Kedi
    {
        public string Ad { get; set; }
        public string Cins { get; set; }
        public void SesCikart()
        {

        }
    }

    public class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool EvliMi { get; set; }
        public decimal Maas { get; set; }
    }


}