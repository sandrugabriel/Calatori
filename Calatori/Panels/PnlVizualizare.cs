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

        public PnlVizualizare(Form1 form1, string circuit)
        {

            form = form1;
            this.form.Size = new System.Drawing.Size(1362, 800);
            this.form.MaximumSize = new System.Drawing.Size(1362, 800);
            this.form.MinimumSize = new System.Drawing.Size(1362, 800);
            controllerPorturi = new ControllerPorturi();
            listPorturi = new List<Port>();
            controllerCroaziere = new ControllerCroaziere();
            listCroaziere = new List<Croaziere>();
            // PnlListCroaziera
            this.Size = new System.Drawing.Size(1362, 800);
            this.Name = "PnlListCroaziera";

            this.pctImg = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pctImg);

            // pctImg
            this.pctImg.Location = new System.Drawing.Point(24, 58);
            this.pctImg.Name = "pctImg";
            this.pctImg.Size = new System.Drawing.Size(1027, 624);
            this.pctImg.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctImg.Paint += new PaintEventHandler(pctImg_Paint);

            // btnSalvare
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1098, 180);
            this.btnBack.Name = "btnSalvare";
            this.btnBack.Size = new System.Drawing.Size(237, 49);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Inchidere";
            this.btnBack.Click += new EventHandler(btnBack_Click);
            this.btnBack.Enabled = false;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {



        }

        private void pctImg_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            foreach (Port port in listPorturi)
            {
                int x = port.getPozX() - 10;
                int y = port.getPozY() - 10;
                g.DrawEllipse(Pens.Red, x, y, 20, 20);

            }



        }


    }
}
