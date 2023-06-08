using Calatori.Controllers;
using Calatori.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calatori.Panels
{
    internal class PnlVizualizare : Panel
    {

        Form1 form;

        private System.Windows.Forms.PictureBox pctImg;
        private System.Windows.Forms.Button btnBack;

        ControllerPorturi controllerPorturi;
        List<Port> listPorturi;
        ControllerCroaziere controllerCroaziere;
        List<Croaziere> listCroaziere;
        private string circuit;
        public PnlVizualizare(Form1 form1, string circuit1)
        {

            form = form1;
            circuit = circuit1;
            this.form.Size = new System.Drawing.Size(1362, 800);
            this.form.MaximumSize = new System.Drawing.Size(1362, 800);
            this.form.MinimumSize = new System.Drawing.Size(1362, 800);
            controllerPorturi = new ControllerPorturi();
            listPorturi = new List<Port>();
            controllerCroaziere = new ControllerCroaziere();
            listCroaziere = new List<Croaziere>();

            // PnlVizualizare
            this.Size = new System.Drawing.Size(1362, 800);
            this.Name = "PnlVizualizare";

            this.pctImg = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pctImg);

            listPorturi = getPorturile();

            // pctImg
            this.pctImg.Location = new System.Drawing.Point(24, 58);
            this.pctImg.Name = "pctImg";
            this.pctImg.Size = new System.Drawing.Size(1027, 624);
            this.pctImg.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctImg.Image = Image.FromFile(Application.StartupPath + @"/imagini/MareaNeagra.jpg");
            this.pctImg.Paint += new PaintEventHandler(pctImg_Paint);

            // btnSalvare
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(1098, 180);
            this.btnBack.Size = new System.Drawing.Size(237, 49);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Inchidere";
            this.btnBack.Click += new EventHandler(btnBack_Click);


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.form.removepnl("PnlVizualizare");
            this.form.Controls.Add(new PnlAutentificarea(form));


        }

        private List<Port> getPorturile()
        {

            List<Port> ports = new List<Port>();

            string[] prop = circuit.Split(',');

            foreach (string s in prop)
                ports.Add(controllerPorturi.getPortbyName(s));

            return ports;
        }

        private void pctImg_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            for (int i = 0; i < listPorturi.Count-2; i++)
            {
                int x = listPorturi[i].getPozX();
                int y = listPorturi[i].getPozY();

               // MessageBox.Show(x.ToString());
                int x1 = listPorturi[i+1].getPozX();
                int y1 = listPorturi[i+1].getPozY();

                g.DrawLine(Pens.Red, x, y, x1, y1);

            }



        }


    }
}
