﻿using Calatori.Controllers;
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
    internal class PnlListCroaziera:Panel
    {

        Form1 form;

        private System.Windows.Forms.PictureBox pctImg;
        private System.Windows.Forms.Button btnInitializare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnGenerare;
        private System.Windows.Forms.Button btnListCroaziere;

        ControllerPorturi controllerPorturi;
        List<Port> listPorturi;
        ControllerCroaziere controllerCroaziere;
        List<Croaziere> listCroaziere;
        public PnlListCroaziera(Form1 form1)
        {

            form = form1;
            this.form.Size = new System.Drawing.Size(1362, 800);
            this.form.MaximumSize = new System.Drawing.Size(1362, 800);
            this.form.MinimumSize = new System.Drawing.Size(1362,800);
            controllerPorturi = new ControllerPorturi();
            listPorturi = new List<Port>();
            controllerCroaziere = new ControllerCroaziere();
            listCroaziere = new List<Croaziere>();
            // PnlListCroaziera
            this.Size = new System.Drawing.Size(1362, 800);
            this.Name = "PnlListCroaziera";

            this.pctImg = new System.Windows.Forms.PictureBox();
            this.btnInitializare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnGenerare = new System.Windows.Forms.Button();
            this.btnListCroaziere = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnListCroaziere);
            this.Controls.Add(this.btnGenerare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnInitializare);
            this.Controls.Add(this.pctImg);

            // pctImg
            this.pctImg.Location = new System.Drawing.Point(24, 58);
            this.pctImg.Name = "pctImg";
            this.pctImg.Size = new System.Drawing.Size(1027, 624);
            this.pctImg.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctImg.MouseDoubleClick += pctImg_DoubleClick;
            this.pctImg.Paint += new PaintEventHandler(pctImg_Paint);
            this.pctImg.Enabled = false;

            // btnInitializare
            this.btnInitializare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitializare.Location = new System.Drawing.Point(1098, 99);
            this.btnInitializare.Name = "btnInitializare";
            this.btnInitializare.Size = new System.Drawing.Size(237, 49);
            this.btnInitializare.Text = "Initializare";
            this.btnInitializare.Click += new EventHandler(btnInitializare_Click);
            
            // btnSalvare
            this.btnSalvare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.Location = new System.Drawing.Point(1098, 180);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(237, 49);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare coordonate";
            this.btnSalvare.Click += new EventHandler(btnSalvare_Click);
            this.btnSalvare.Enabled = false;
            
            // btnGenerare
            this.btnGenerare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerare.Location = new System.Drawing.Point(1098, 451);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(237, 49);
            this.btnGenerare.TabIndex = 4;
            this.btnGenerare.Text = "Generare croaziere";
            this.btnGenerare.Click += new EventHandler(btnGenerare_Click);
            
            // btnListCroaziere
            this.btnListCroaziere.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCroaziere.Location = new System.Drawing.Point(1098, 519);
            this.btnListCroaziere.Name = "btnListCroaziere";
            this.btnListCroaziere.Size = new System.Drawing.Size(237, 49);
            this.btnListCroaziere.TabIndex = 5;
            this.btnListCroaziere.Text = "Lista Croaziere";
            this.btnListCroaziere.Click += new EventHandler(btnListCroaziere_Click);

        }

        private void btnInitializare_Click(object sender, EventArgs e)
        {
            this.pctImg.Enabled = true;
            this.pctImg.Image = Image.FromFile(Application.StartupPath + @"/imagini/MareaNeagra.jpg");
            listPorturi = controllerPorturi.getPorturi();
            this.pctImg.Refresh();

        }

        private int x, y;

        private void pctImg_DoubleClick(object sender, MouseEventArgs e)
        {

             x = e.X;
             y = e.Y;

            MessageBox.Show($"Coordonatele sunt: X = {x}, Y = {y}");
            this.btnSalvare.Enabled = true;

        }

        private void btnSalvare_Click(Object sender, EventArgs e)
        {

            this.form.removepnl("PnlListCroaziera");
            this.form.Controls.Add(new PnlSalvare(form, x, y));


        }

        private void pctImg_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            foreach (Port port in listPorturi)
            {
                int x = port.getPozX()-10;
                int y = port.getPozY()-10;
                    g.DrawEllipse(Pens.Red, x, y, 20, 20);

            }



        }

        private void btnGenerare_Click(object sender, EventArgs e)
        {

            Random random = new Random();


            string textul;

            for(int i = 0; i < 15; i++)
            {
                textul = "";
                int id = controllerCroaziere.generareId();
                textul = id.ToString() + ",";
                Random random1 = new Random();
                int[] allowedNumbers = { 3, 5, 8 };

                int tip = allowedNumbers[random.Next(allowedNumbers.Length)];
                textul += tip + ",";
                if(tip == 3)
                for (int k = 0; k < 4; k++)
                {
                    int rand = random.Next(1,13);

                    textul += rand.ToString() + ",";

                }
                else if(tip == 5) 
                    for (int k = 0; k < 7; k++)
                    {
                        int rand = random.Next(1, 13);

                        textul += rand.ToString() + ",";

                    }
                else
                    for (int k = 0; k < 10; k++)
                    {
                        int rand = random.Next(1, 13);

                        textul += rand.ToString() + ",";

                    }

                if (tip == 3)
                    textul += DateTime.Today.AddDays(2) + "," + DateTime.Today.AddDays(5)+","+1304;
                else if (tip == 5)
                    textul += DateTime.Today.AddDays(2) + "," + DateTime.Today.AddDays(7)+","+2800;
                else
                    textul += DateTime.Today.AddDays(2) + "," + DateTime.Today.AddDays(10)+","+5100;

                textul += "," + 100;


                controllerCroaziere.save(textul);
            }


          

            MessageBox.Show("Croazierele s-sau generat cu succes","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnListCroaziere_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlListCroaziera");
            listCroaziere.Clear();
            listCroaziere = controllerCroaziere.getCroaziere();
            this.form.Controls.Add(new PnlList(form, listCroaziere));


        }

    }
}
