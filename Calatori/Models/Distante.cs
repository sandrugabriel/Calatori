using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace Calatori.Models
{
    internal class Distante
    {

        private int id;
        private int idPort;
        private int idPortDestinatie;
        private string name;
        private int distanta;

        public Distante(int id, int idPort, int idPortDestinatie, string name, int distanta)
        {
            this.id = id;
            this.idPort = idPort;
            this.idPortDestinatie = idPortDestinatie;
            this.name = name;
            this.distanta = distanta;
        }

        public Distante(string text) {

            string[] prop = text.Split(' ');

            this.id = int.Parse(prop[0]);
            this.idPort = int.Parse(prop[1]);
            this.idPortDestinatie = int.Parse(prop[2]);
            this.name = prop[3];
            this.distanta = int.Parse(prop[4]);
        
        }

        public int getId()
        {
            return id;
        }

        public int getIdPort()
        {
            return idPort;
        }

        public int getIdPortDestinatie()
        {
            return idPortDestinatie;
        }

        public string getName()
        {
            return name;
        }

        public int getDistanta()
        {
            return distanta;
        }


    }
}
