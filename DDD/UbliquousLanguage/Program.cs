namespace UbliquousLanguage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Aşı yapıyoruz
             */
            // Hastalara, grip aşısı yapıyoruz.
            //Hemşire, hastalara grip aşısını standart dozda uygular.

            Hasta hasta = new Hasta();
            GripAsisi gripAsisi = new GripAsisi { StandartDoz = 3 };

            Hemsire hemsire = new Hemsire();


            hemsire.GripAsisiYap(hasta, gripAsisi.StandartDoz);

        }


    }

    public class Hemsire
    {
        public void GripAsisiYap(Hasta hasta, int doz)
        {

        }
    }

    public class Hasta
    {

    }

    public class GripAsisi
    {
        public int StandartDoz { get; set; }
    }
}