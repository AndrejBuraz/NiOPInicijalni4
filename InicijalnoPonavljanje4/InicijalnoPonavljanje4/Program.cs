using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napišite program koji će provjeriti jesu li vrijednosti sadržane u int varijablama x, y i z stranice pravokutnog trokuta. 
            U program uključite i provjeru da vrijednosti varijabli za ovakav primjer imaju smislene vrijednosti (iznosi moraju biti veći od 0).
             */
            int x, y, z;
            unos: Console.WriteLine("Unesi vrijednost x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi vrijednost y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesi vrijednost z: ");
            z = Convert.ToInt32(Console.ReadLine());
            if(x < 1 || y < 1 || z < 1)
            {
                Console.WriteLine("Vrijednosti moraju biti veće od 1!");
                goto unos;
            }
            if((Math.Pow(x,2)) + Math.Pow(y,2) == Math.Pow(z,2))
            {
                Console.WriteLine("Sadržane varijable sadrže vrijednosti pravokutnog trokuta");
            }
            else
            {
                Console.WriteLine("Varijable ne sadrže vrijednosti pravokutnog trokuta");
            }
            Console.ReadKey();

        }
    }
}
