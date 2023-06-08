using Calatori.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calatori.Panels
{
    internal class PnlSalvare:Panel
    {

        Form1 form;

        Label label;
        TextBox textBox;
        Button btnSalvare;
        private int x, y;
        ControllerPorturi controllerPorturi;

        public PnlSalvare(Form1 form1, int x1, int y1)
        {

            label = new Label();
            textBox = new TextBox();
            btnSalvare = new Button();
            form = form1;
            x = x1;
            y = y1;
            controllerPorturi = new ControllerPorturi();

            this.form.Size = new System.Drawing.Size(300, 300);
            this.form.MinimumSize = new System.Drawing.Size(300, 300);
            this.form.MaximumSize = new System.Drawing.Size(300, 300);

            this.Size = new System.Drawing.Size(300,300);
            this.Name = "PnlSalvare";
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13);

            this.Controls.Add(label);
            this.Controls.Add(textBox);
            this.Controls.Add(btnSalvare);

            //label
            this.label.Location = new System.Drawing.Point(50, 5);
            this.label.Text = "Introduceti numele portului";
            this.label.AutoSize = true;

            //textbox
            this.textBox.Location = new System.Drawing.Point(50, 60);
            this.textBox.Size = new System.Drawing.Size(120, 40);

            //btnSalvare
            this.btnSalvare.Location = new System.Drawing.Point(70,100);
            this.btnSalvare.AutoSize = true;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.Click += new EventHandler(btnSalvare_Click);

        }

        private void btnSalvare_Click(object sender, EventArgs e) {

            if (!textBox.Text.Equals(""))
            {
                int id = controllerPorturi.generareId();
                string name = textBox.Text;
                int pozx = x;
                int pozy = y;
                string text = id.ToString() + "," + name + "," + pozx.ToString() + "," + pozy.ToString();
                controllerPorturi.save(text);

                this.form.removepnl("PnlSalvare");
                this.form.Controls.Add(new PnlListCroaziera(this.form));

            }
            else MessageBox.Show("Introduceti numele!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
        
        
        }





    }
}
