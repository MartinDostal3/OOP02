using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    class Atlet
    {
        private int unava = 0;
        public string Jmeno { get; /*private set;*/ }
        private string prijmeni;
       // public string Prijmeni { get; set; }
       public string Prijmeni
        {
            get
            {
                return prijmeni;
            }
            set
            {
                string p = value;
                p = char.ToUpper(p[0]) + p.Substring(1);
                prijmeni = p;
             
                    
             }
        }

        public Atlet(string jmeno, String prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }
        public int GetUnava()
        {
            return unava;
        }

        public void Behej(int vzdalenost)
        {
            if (unava + vzdalenost * 10 <= 200) unava += vzdalenost * 10;
            else
            {
                System.Windows.Forms.MessageBox.Show("jsem příliš unavený");
            }
        }
        public void Spi(int hodina)
        {
            while (unava >= 0 && hodina !=0 )
            {
                if(unava >= 100)
                {
                    unava = unava - 100;
                }
                else
                {
                    unava = 0;
                }
                --hodina;
                
            }

        }


    }
}
