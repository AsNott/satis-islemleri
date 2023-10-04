namespace deneme____ticari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            label:
            Console.WriteLine("islem seciniz");
            Console.WriteLine("0 - cikis");
            Console.WriteLine("1- kar orani hesaplama");
            Console.WriteLine("2- satis fiyati hesaplama");
            Console.WriteLine("3- alis  fiyati hesaplama");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                karorani();
                goto label;
            }
            else if( secim == 2)
            {
                satisfiyati();
                goto label;
            }
            else if( secim == 3)
            {
                alisfiyati();
                goto label;
            }
            else if (secim == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("------ HATALI SECIM YAPTINIZ--------");
                Console.Write("lutfen tekrar ");
                goto label;
            }
        }

        static void karorani()
        {
            string print = "";
            Console.WriteLine("alis fiyati giriniz: ");
            double alis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("satis fiyati giriniz: ");
            double satis = Convert.ToInt32(Console.ReadLine());

            double karorani =  (satis - alis) * 100.0 / alis;
            print = "kar oraniniz = %" + karorani;
            Console.WriteLine(print);
        }

        static void satisfiyati()
        {
            string print = "";
            Console.WriteLine("alis fiyati giriniz: ");
            double alis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kar orani giriniz: ");
            double karorani = Convert.ToInt32(Console.ReadLine());

            double satisfiyati = (alis * karorani / 100.0) + alis;
            print = "istediginiz kara uygun satis fiyati = " + satisfiyati;
            Console.WriteLine(print);
        }

        static void alisfiyati()
        {
            string print = "";
            Console.WriteLine("satis fiyati giriniz: ");
            double satis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kar orani giriniz: ");
            double karorani = Convert.ToInt32(Console.ReadLine());

            double alisfiyati = (satis * 100.0) / (karorani + 100.0);
            print = "istediginiz kara uygun satis fiyati = " + alisfiyati;
            Console.WriteLine(print);
        }

    }
}