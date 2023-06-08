using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Calatori.Models
{
    internal class Croaziere
    {

        private int id;
        private int tipCroaziera;
        private List<int> listPorturi = new List<int>();
        private DateTime dataStart;
        private DateTime dataEnd;
        private int pret;
        private int nrPasageri;

        public Croaziere(int id, int tipCroaziera, List<int> listPorturi, DateTime dataStart, DateTime dataEnd, int pret, int nrPasageri)
        {
            this.id = id;
            this.tipCroaziera = tipCroaziera;
            this.listPorturi = listPorturi;
            this.dataStart = dataStart;
            this.dataEnd = dataEnd;
            this.pret = pret;
            this.nrPasageri = nrPasageri;
        
        }

        public Croaziere(string text) {
            string[] prop = text.Split(',');
            this.id = int.Parse(prop[0]);
            this.tipCroaziera = int.Parse(prop[1]);
            int ct = 2;
            if (tipCroaziera == 3)
                for (int i = 0; i < 4; i++)
                {
                    this.listPorturi.Add(int.Parse(prop[ct]));
                    ct++;
                }
            else if (tipCroaziera == 5)
                for (int i = 0; i < 7; i++)
                {
                    this.listPorturi.Add(int.Parse(prop[ct]));
                    ct++;
                }
            else
                for (int i = 0; i < 10; i++)
                {
                    this.listPorturi.Add(int.Parse(prop[ct]));
                    ct++;
                }
            this.dataStart = DateTime.Parse(prop[ct]);
            this.dataEnd = DateTime.Parse(prop[ct + 1]);
            this.pret = int.Parse(prop[ct + 2]);
            this.nrPasageri = int.Parse((prop[ct + 3]));

        }

        public int getId() { return id; }

        public int getTipCroaziera()
        {
            return tipCroaziera;
        }

        public List<int> getListPorturi()
        {
            return listPorturi;
        }

        public DateTime getDataStart()
        {
            return dataStart;
        }

        public DateTime getDataEnd()
        {
            return dataEnd;
        }

        public int getNumPasageri() { 
        
            return nrPasageri;
        }

        public int getPret()
        {
            return pret;
        }


    }
}
