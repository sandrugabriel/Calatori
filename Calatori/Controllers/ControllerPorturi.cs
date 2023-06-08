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
    internal class ControllerPorturi
    {

        private List<Port> porturi;

        public ControllerPorturi()
        {

            porturi = new List<Port>();

            load();

        }

        public void load() {

            string path = Application.StartupPath + @"/data/porturi.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {

                Port port = new Port(t);

                porturi.Add(port);

            }

            streamReader.Close();
        }

        public List<Port> getPorturi()
        {
            return porturi;
        }

        public Port getPortById(int id)
        {

            for (int i = 0; i < porturi.Count; i++)
            {
                if (porturi[i].getId() == id)
                {
                    return porturi[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getPortById(id) != null)
            {

                id = random.Next();

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/porturi.txt";
            File.AppendAllText(path, text + "\n");


        }

        public string namebyId(int id)
        {

            for(int i = 0; i < porturi.Count; i++)
            {
                if (porturi[i].getId() == id)
                    return porturi[i].getName();
            }

            return null;
        }
    }
}
