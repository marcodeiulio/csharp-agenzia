using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    public class Appartamento : Immobile
    {
        public int Vani { get; set; }
        public int Bagni { get; set; }
        public Appartamento(int vani, int bagni, string alfaNum, string indirizzo, int cap, string citta, int superficie) : base(alfaNum, indirizzo, cap, citta, superficie)
        {

            this.Vani = vani;
            this.Bagni = bagni;
        }
        public override string ToString()
        {
            return string.Format("Appartamento:\n{0}", Write());
        }
        protected override string Write()
        {
            return string.Format("\nVani: {0} \nBagni{1}", base.Write(), this.Vani, this.Bagni);
        }
        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.Vani.ToString().Contains(key)) return true;
            else if (this.Bagni.ToString().Contains(key)) return true;
            else return false;
        }

    }
}