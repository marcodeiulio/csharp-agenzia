using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    public class Box : Immobile
    {
        public int PostiAuto { get; set; }

        public Box(int postiAUto, string alfaNum, string indirizzo, int cap, string citta, int superficie) : base(alfaNum, indirizzo, cap, citta, superficie)
        {
            this.PostiAuto = postiAUto;

        }
        public override string ToString()
        {
            return string.Format("Box:\n{0}", Write());
        }
        protected override string Write()
        {
            return string.Format("\nPostiAuto: {0}", base.Write(), this.PostiAuto);
        }
        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.PostiAuto.ToString().Contains(key)) return true;
            else return false
        }


    }
}