using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppasitBazAyirci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tadına bakılabiliyor mu ? (bakılabiliyorsa 1,bakılmıyorsa 0'a tıklayınız)");
            int tadımVarmı = Convert.ToInt32(Console.ReadLine());
            if (tadımVarmı == 1)
            {
                Console.WriteLine("tadı acı mı,ekşi mi?(ekşiyse 1'e ,acıysa 0'a tıklayınız)");
                int acımıEksimi = Convert.ToInt32(Console.ReadLine());

                if (acımıEksimi == 1)
                    Console.WriteLine(" asit");

                if (acımıEksimi == 0)
                    Console.WriteLine(" baz");

            }


            if (tadımVarmı == 0)
            {

                Console.WriteLine("Turnusol kağıdınız var mı ?(varsa 1'e yoksa 0'a tıklayınız");
                int turnusolKagidiVarmıYokmu = Convert.ToInt32(Console.ReadLine());

                if (turnusolKagidiVarmıYokmu == 1)
                {
                                                   
                   Console.WriteLine("hangi renge dönüyor ?(kırmızıysa 1,maviyse 0'a tıklayınıznnnn");
                   int turnusolDönenRenk = Convert.ToInt32(Console.ReadLine());

                   if (turnusolDönenRenk == 1)
                        Console.WriteLine(" asit");

                   if (turnusolDönenRenk == 0)
                        Console.WriteLine(" baz ");
                                   
                }
                if (turnusolKagidiVarmıYokmu == 0)
                {
                    Console.WriteLine("fenolftalein var mı ?(varsa 1'e,yoksa 0'a tıklayınız");
                    int fenolftaleinVarmıYokmu = Convert.ToInt32(Console.ReadLine());

                    if (fenolftaleinVarmıYokmu == 1)
                    {
                        Console.WriteLine("hangi renge dönüyor ?(renksizse 1,pembeyse 0'a tıklayınız");
                        int fenolftaleinDönenRenk = Convert.ToInt32(Console.ReadLine());

                        if (fenolftaleinDönenRenk == 1)
                            Console.WriteLine(" asit");

                        if (fenolftaleinDönenRenk == 0)
                            Console.WriteLine(" baz ");
                    }
                    if (fenolftaleinVarmıYokmu == 0)
                    {
                        Console.WriteLine("metil oranj var mı ?(varsa 1'e,yoksa 0'a tıklayınız");
                        int metilOranjVarmıYokmu = Convert.ToInt32(Console.ReadLine());

                        if (metilOranjVarmıYokmu == 1)
                        {
                            Console.WriteLine("hangi renge dönüyor ?(kırmızıysa 1'e ,sarıysa 0'a tıklayınız");
                            int fenolftaleinDönenRenk = Convert.ToInt32(Console.ReadLine());

                            if (fenolftaleinDönenRenk == 1)
                                Console.WriteLine(" asit");

                            if (fenolftaleinDönenRenk == 0)
                                Console.WriteLine(" baz ");
                        }
                        if (metilOranjVarmıYokmu == 0)
                        {


                            Console.WriteLine("sulu çözeltisi hidrojen iyonu veriyormu ?/sulu çözeltisi hidroksit iyonu verir mi?" +
                            "(hidrojen iyonu veriyorsa 1'e ,hidroksit iyonu veriyorsa 0'a tıklayınız");
                            int verdigiyon = Convert.ToInt32(Console.ReadLine());

                            if (verdigiyon == 1)
                                Console.WriteLine("asit");

                            if (verdigiyon == 0)
                                Console.WriteLine("baz");
                        }
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
