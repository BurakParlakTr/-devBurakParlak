namespace ÖdevBurakParlak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            int ksayac = 0;
            int r = 0;
            Random rnd = new Random();
            int rnumber = rnd.Next(r);
            int dsayı;
            int can = 100;
            int e = 0;
            Console.WriteLine("k,o,z");
            Console.WriteLine("seviye seçiniz");
            string zorluk = Console.ReadLine();

            if (zorluk == "k")
            {

                ksayac = 10;
                r = 3;
                e = 10;

            }
            if (zorluk == "o")
            {
                ksayac = 5;
                r = 6;
                e = 20;

            }
            if (zorluk == "z")
            {
                ksayac = 4;
                r = 12;
                e = 50;
            }



            do
            {
                can -= e;
                sayac++;
                Console.WriteLine("doğru sayı ne ?");
                dsayı = int.Parse(Console.ReadLine());
                if (can == 0)
                {
                    Console.WriteLine("canın bitti oyunu kayıp ettin ");
                    break;

                }
                if (sayac == ksayac)
                {
                    break;
                }
            } while (dsayı != rnumber);
            if (dsayı == rnumber) { Console.WriteLine("doğru cevap"); }
            if (sayac == ksayac) { Console.WriteLine("hakkın doldu"); }

        }
    }
}