using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calatori.Models
{
    internal class Port
    {

        private int id;
        private string name;
        private int pozX;
        private int pozY;

        public Port(int id, string name, int pozX, int pozY)
        {
            this.id = id;
            this.name = name;
            this.pozX = pozX;
            this.pozY = pozY;
        }

        public Port(string text)
        {

            string[] prop = text.Split(',');

            this.id = int.Parse(prop[0]);
            this.name = prop[1];
            this.pozX = int.Parse(prop[2]);
            this.pozY = int.Parse(prop[3]);

        }

        public int getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public int getPozX()
        {
            return this.pozX;
        }

        public int getPozY()
        {
            return this.pozY;
        }
    }
}
