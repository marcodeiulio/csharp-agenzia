using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    class Agenzia
    {
        public string Nome { get; set; }
        public List<Immobile> Immobili { get; set; }
        public Agenzia(string nome)
        {
            this.Nome = nome;
            this.Immobili = new List<Immobile>();
        }
        public void AddImmobile(Immobile immobile)
        {
            this.Immobili.Add(immobile);
        }
        public List<Immobile> CercaImmobili(string key)
        {


            return this.Immobili.FindAll(i => i.Contains(key));
        }
    }
}