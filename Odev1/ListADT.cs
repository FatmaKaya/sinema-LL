using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public abstract class ListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertFirst(Koltuk value);
        public abstract void InsertLast(Koltuk value);
        public abstract String InsertPos(int position, Koltuk value);
        public abstract String DeletePos(int position, Koltuk value);
        public abstract Koltuk GetElement(Koltuk position);
        public abstract string DisplayElements();

    }
}
