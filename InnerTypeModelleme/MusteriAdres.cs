using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeModelleme
{
    public class MusteriAdres
    {
        public string AdresTip { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Ardres { get; set; }

        public MusteriAdres()
        {
            Console.WriteLine("Musteri Adres Çalıştı.");
        }
        public void MusteriAdresTestMetot()
        {
            Console.WriteLine("MusteriAdresTestMetot");
        }
    }
}
