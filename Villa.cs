using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    public class Villa : Appartamento
    {

        public int Giardino { get; set; }
        public Villa(int giardino, int vani, int bagni, string alfaNum, string indirizzo, int cap, string citta, int superficie) : base(vani, bagni, alfaNum, indirizzo, cap, citta, superficie)
        {

            this.Giardino = giardino;

        }
        public override string ToString()
        {
            return string.Format("\nVilla: {0}", Write());
        }
        protected override string Write()
        {
            return string.Format("\nGiardino: {0} ", base.Write(), this.Giardino);
        }
        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.Giardino.ToString().Contains(key)) return true;
            else return false;
        }

    }
}