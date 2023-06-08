using Calatori.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calatori.Controllers
{
    internal class ControllerCroaziere
    {

        private List<Croaziere> croaziere;
        

        public ControllerCroaziere()
        {

            croaziere = new List<Croaziere>();

            load();
        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/croaziere.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {
                Croaziere croaziera = new Croaziere(t);
                croaziere.Add(croaziera);
            }

        }


        public Croaziere getCroazieraById(int id)
        {

            for (int i = 0; i < croaziere.Count; i++)
            {
                if (croaziere[i].getId() == id)
                {
                    return croaziere[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getCroazieraById(id) != null)
            {

                id = random.Next();

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/croaziere.txt";
            File.AppendAllText(path, text + "\n");


        }

        public List<Croaziere> getCroaziere()
        {

            return croaziere;
        }

        public List<Croaziere> getCroaziereTip(int tip)
        {
            List<Croaziere> l = new List<Croaziere>();
            for(int i = 0; i < croaziere.Count; i++)
            {
                if (croaziere[i].getTipCroaziera() == tip)
                {
                    l.Add(croaziere[i]);
                }
            }
            return l;
        }
    }
}
