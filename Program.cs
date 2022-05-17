/*
 * Esercizio 2: Agenzia immobiliare

Si vuole progettare un’applicazione in grado di gestire un’agenzia 
immobiliare. 

Gli immobili sono caratterizzati da:
- un codice alfanumerico, 
- indirizzo, 
- cap, 
- città 
- una superficie espressa in mq attraverso un numero intero. 


L’agenzia gestisce diverse tipologie di immobili: 
- Box, 
- Appartamenti 
- Ville.

Per i box è riportato il numero di posti auto. 
Per gli appartamenti è 
riportato in numero di vani e il numero di bagni.

Per le ville è previsto, 
in aggiunta rispetto all’appartamento, la dimensione in mq di giardino.

Ridefinire per ciascuna delle tre classi il metodo ToString in modo da fornire 
una descrizione completa dell'immobile. StampaSchedaImmobile

Provare a pensare ad una funzione di ricerca.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    class Program
    {
        static void Main(string[] args)
        {
            Villa v = new Villa(220, 4, 3, "Aa1", "Roma 512", 47121, "Forli", 190);
            Appartamento a = new Appartamento(3, 2, "Ab2", "Spazzoli 34", 47121, "Forli", 142);
            Agenzia agenzia = new Agenzia("Ciccoli");

            agenzia.AddImmobile(v);
            List<Immobile> listaImmobili = agenzia.CercaImmobili("Forli");
            foreach (Immobile immobile in listaImmobili)
            {
                Console.WriteLine(immobile);
            }



        }
    }
}