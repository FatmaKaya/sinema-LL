using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public class LinkedList : ListADT
    {

        public override string DeletePos(int position, Koltuk value)
        {
            string a = "";
            Node posNode = null;
            Node tempNext = Head;
            while (tempNext != null)
            {
                if (tempNext.Data.KoltukNo == position)
                {
                    posNode = tempNext;
                    break;
                }
                tempNext = tempNext.Next;
            }
            if (posNode.Data.KoltukDurumu == true && posNode.Data.KoltuktakiKisiAdSoyad == value.KoltuktakiKisiAdSoyad)
            {
                posNode.Data.KoltuktakiKisiAdSoyad = "";
                posNode.Data.KoltukDurumu = false;
                a = "Koltuk başarıyla iptal edildi!.";
            }
            else if (posNode.Data.KoltuktakiKisiAdSoyad != value.KoltuktakiKisiAdSoyad)
                a = "Bu koltukta bu kişi oturmuyor!.";
            else
                a = "bu koltuk zaten boş!.";
            return a;
        }

        public override string DisplayElements()
        {
            Node tempNode = Head;
            string temp = "\n------KOLTUKLAR-----\n";
            while (tempNode != null)
            {
                temp += tempNode.Data.KoltukNo + ". Koltuk:" + tempNode.Data.KoltuktakiKisiAdSoyad + "  ";
                tempNode = tempNode.Next;
            }
            return temp+DoluKoltuklar()+BosKoltuklar()+ DoluKoltuksayisi();
        }

        public override Koltuk GetElement(Koltuk position)
        {
            Node retNode = null;
            Node tempNode = Head;

            while (tempNode != null)
            {
                if (tempNode.Data.KoltuktakiKisiAdSoyad== position.KoltuktakiKisiAdSoyad)
                {
                    retNode = tempNode;
                    break;
                }
                tempNode = tempNode.Next;
            }
            return retNode.Data;
        }

        public override void InsertFirst(Koltuk value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;
        }

        public override void InsertLast(Koltuk value)
        {
            Node oldLast = Head;

            if (Head == null)
                InsertFirst(value);
            else
            {
                Node newLast = new Node
                {
                    Data = value
                };
                while (oldLast != null)
                {
                    if (oldLast.Next != null)
                        oldLast = oldLast.Next;
                    else
                        break;
                }

                oldLast.Next = newLast;
                Size++;
            }
        }

        public override String InsertPos(int position, Koltuk value)
        {
            string a="";
            Node posNode=null;
            Node tempNext = Head;
            

            Node newNode = new Node
            {
                Data = value
            };
            
            while(tempNext!=null)
            {
                if(tempNext.Data.KoltukNo==position)
                {
                    posNode = tempNext;
                    break;
                }
                tempNext = tempNext.Next;
            }
            if (posNode.Data.KoltukDurumu == false)
            {
                posNode.Data.KoltuktakiKisiAdSoyad = newNode.Data.KoltuktakiKisiAdSoyad;
                posNode.Data.KoltukDurumu = newNode.Data.KoltukDurumu;
                a = "Koltuk başarıyla alındı!.";
            }
            else
            {
                a=("Bu koltuk başkası tarafından alınmıştır. Lütfen başka bir koltuk seçiniz!.");
            }
            return a;
        }

        private String DoluKoltuksayisi()
        {
            int toplamSayi = 0;
            string temp = "\n\n---SALONDAKİ KİŞİ SAYISI:";
            Node tempNode =Head;
            while (tempNode != null)
            {
                if (tempNode.Data.KoltukDurumu == true)
                    toplamSayi++;      
                tempNode = tempNode.Next;
            }
            temp += toplamSayi;
            return temp;
        }

        private string DoluKoltuklar()
        {
            Node tempNode = Head;
            string temp = "\n\n------DOLU KOLTUKLAR----\n";
            while (tempNode != null)
            {
                if(tempNode.Data.KoltukDurumu == true)
                temp += tempNode.Data.KoltukNo + ". Koltuk:" +tempNode.Data.KoltuktakiKisiAdSoyad + "  ";
               tempNode = tempNode.Next;
            }
            return temp;
        }

        private string BosKoltuklar()
        {
            Node tempNode = Head;
            string temp = "\n\n------BOŞ KOLTUKLAR----\n";
            while (tempNode != null)
            {
                if (tempNode.Data.KoltukDurumu == false)
                    temp += tempNode.Data.KoltukNo + ". Koltuk  ";
                tempNode = tempNode.Next;
            }
            return temp;
        }

    }
  

}

