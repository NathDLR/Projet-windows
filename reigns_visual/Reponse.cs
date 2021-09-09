using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reigns_visual
{
    class Reponse
    {
        private string choix;
        private int eglise;
        private int population;
        private int armee;
        private int argent;

        public Reponse(string choix, int eglise, int population, int armee, int argent)
        {
            this.choix = choix;
            this.eglise = eglise;
            this.population = population;
            this.armee = armee;
            this.argent = argent;
        }
        public Reponse(string choix, int eglise, int population, int armee, int argent, string desc)
        {
            this.choix = choix;
            this.eglise = eglise;
            this.population = population;
            this.armee = armee;
            this.argent = argent;
        }
        public string getChoix()
        {
            return this.choix;
        }
        public int getEglise()
        {
            return this.eglise;
        }
        public int getPopulation()
        {
            return this.population;
        }
        public int getArmee()
        {
            return this.armee;
        }
        public int getArgent()
        {
            return this.argent;
        }
    }
}
