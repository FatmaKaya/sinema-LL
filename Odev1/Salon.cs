using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public class Salon
    {
        public LinkedList Koltuklar = new LinkedList();

        public Salon()
        {
            
            for(int i = 1; i <= 60; i++)
            {
                Koltuk k = new Koltuk();
                k.KoltukNo = i;
                k.KoltukDurumu = false;
                Koltuklar.InsertLast(k);
            }
        }

    }
}
