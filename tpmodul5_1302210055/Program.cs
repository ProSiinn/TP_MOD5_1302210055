using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302210055
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PanggilanNama = "Rafi";
            HaloGeneric.SapaUser(PanggilanNama);
        }
    }

    public class HaloGeneric
    {
        public static void SapaUser<T>(T input)
        {
            Console.WriteLine("Halo user " + input);

        }
    }
}
