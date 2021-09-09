using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reigns_visual
{
    class Evenement
    {
        private string enonce;
        private List<Reponse> reponses = new List<Reponse>();

        public Evenement(string enonce)
        {
            this.enonce = enonce;
        }

        public void ajoutReponse(string choix, int eglise, int population, int armee, int argent)
        {
            Reponse rep = new Reponse(choix, eglise, population, armee, argent);
            this.reponses.Add(rep);
        }
        public string getEnonce()
        {
            return this.enonce;
        }
        public Reponse getReponse(int idEvent)
        {
            return this.reponses[idEvent];
        }


    }
}
