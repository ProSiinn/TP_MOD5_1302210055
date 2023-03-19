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

            DataGeneric<string> dataString = new DataGeneric<string>("1302210055");
            dataString.PrintData();
        }
    }

    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
}
