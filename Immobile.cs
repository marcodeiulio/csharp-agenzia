using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    public class Immobile
    {
        public string AlfaNum { get; set; }
        public string Indirizzo { get; set; }
        public int Cap { get; set; }
        public string Citta { get; set; }
        public int Superficie { get; set; }
        public Immobile(string alfaNum, string indirizzo, int cap, string citta, int superficie)
        {
            this.AlfaNum = alfaNum;
            this.Indirizzo = indirizzo;
            this.Cap = cap;
            this.Citta = citta;
            this.Superficie = superficie;
        }
        protected virtual string Write()
        {
            return string.Format("\nAlfaNum:{0} \nIndirizzo:{1} \nCap:{2} \nSuperficie:{3}",
                                    this.AlfaNum, this.Indirizzo, this.Cap, this.Superficie);
        }
        public virtual bool Contains(string key)
        {

            if (this.AlfaNum.Contains(key)) return true;
            else if (this.Indirizzo.Contains(key)) return true;
            else if (this.Cap.ToString().Contains(key)) return true;
            else if (this.Citta.Contains(key)) return true;
            else if (this.Superficie.ToString().Contains(key)) return true;
            else return false;
        }

    }
}