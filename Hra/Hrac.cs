using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace Hra
{
    internal class Hrac : HerniPostava
    {
        private string specializace;
        public string Specializace
        {
            get { return this.specializace; }
            set {
                string[] povolene = { "Kouzelník", "Berserker", "Inženýr", "Cizák" };
                if (povolene.Contains(value)) this.specializace = value;
            }
        }
        private enum Oblicej
        {
            velky_nos,
            usoplesk,
            make_up
        }
        private enum Vlasy
        {
            drdol,
            culik,
            pleska
        }
        private enum BarvaVlasu
        {
            kastanova,
            blond,
            cervena
        }
        private int oblicej = (int)Oblicej.velky_nos;
        private int vlasy = (int)Vlasy.drdol;
        private int barvaVlasu = 0;
        public int XP = 0;

        public Hrac(string jmeno, string specializace, int oblicej, int vlasy, int barvaVlasu) : base(jmeno)
        {
            this.Specializace = specializace;
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barvaVlasu = barvaVlasu;
        }
        public void PridejXP(int hodnota)
        {
            this.XP += hodnota;
            if (this.XP % 100 == 0)
            {
                base.level++;
            }
        }
        public override string ToString()
        {
            return base.ToString()+
                $"Specializace: {this.Specializace}\n" +
                $"Obličej: {this.oblicej}\n" +
                $"Vlasy: {this.vlasy}\n" +
                $"Barva vlasů: {this.barvaVlasu}\n" +
                $"XP: {this.XP}\n";
        }
    }
}
