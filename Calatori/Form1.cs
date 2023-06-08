using Calatori.Controllers;
using Calatori.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calatori
{
    public partial class Form1 : Form
    {

        ControllerCroaziere controllerCroaziere;
        List<Croaziere> list;
        public Form1()
        {
            InitializeComponent();
            controllerCroaziere = new ControllerCroaziere();
            list = controllerCroaziere.getCroaziere();
            this.Controls.Add(new Panels.PnlTurist(this,list));
        }

        public void removepnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {
                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);

        }

    }
}
