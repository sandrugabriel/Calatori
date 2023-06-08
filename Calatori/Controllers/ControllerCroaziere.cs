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






    }
}
