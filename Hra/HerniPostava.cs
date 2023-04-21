using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hra
{
    internal class HerniPostava
    {
        private string jmeno;
        public string Jmeno
        {
            get { return jmeno; }
            set
            {
                if (value.Length <= 10) this.jmeno = value;
                else MessageBox.Show("Příliš dlouhé jméno!");
            }
        }
        protected int level = 1;

        private int poziceX = 0;
        public int PoziceX
        {
            get { return this.PoziceX; }
        }

        private int poziceY = 0;
        public int PoziceY
        {
            get { return this.PoziceY; }
        }
        public HerniPostava(string jmeno)
        {
            this.Jmeno = jmeno;
        }
        public void ZmenaPozice()
        {
            this.poziceX++;
            this.poziceY++;
        }
        public override string ToString()
        {
            return $"Jmeno: {this.Jmeno}\n" +
                $"Level: {this.level}\n" +
                $"Pozice X: {this.PoziceX}\n" +
                $"Pozice Y: {this.PoziceY}\n";
        }
    }
}
