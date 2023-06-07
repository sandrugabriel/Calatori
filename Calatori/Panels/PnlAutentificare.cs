using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calatori.Panels
{
    internal class PnlAutentificare:Panel
    {


        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnAutent;

        Form1 form;

        public PnlAutentificare(Form1 form1)
        {

            form = form1;
            this.form.Size = new System.Drawing.Size(549, 600);
            this.form.MinimumSize = new System.Drawing.Size(549, 600);
            this.form.MaximumSize = new System.Drawing.Size(549, 600);

            this.Size = new System.Drawing.Size(549, 563);
            this.Name = "pnlAutentificare";

            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnAutent = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnAutent);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblTitlu);
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(133, 53);
            this.lblTitlu.Size = new System.Drawing.Size(215, 45);
            this.lblTitlu.Text = "Autentificare";
             
            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.8F);
            this.lblNume.Location = new System.Drawing.Point(86, 183);
            this.lblNume.Size = new System.Drawing.Size(91, 35);
            this.lblNume.Text = "Nume";
             
            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.8F);
            this.lblParola.Location = new System.Drawing.Point(86, 313);
            this.lblParola.Size = new System.Drawing.Size(91, 35);
            this.lblParola.Text = "Parola";
             
            // txtNume
            this.txtNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(92, 221);
            this.txtNume.Size = new System.Drawing.Size(298, 38);
             
            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.Location = new System.Drawing.Point(92, 351);
            this.txtParola.Size = new System.Drawing.Size(298, 38);
             
            // btnAutent
            this.btnAutent.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutent.Location = new System.Drawing.Point(151, 455);
            this.btnAutent.Size = new System.Drawing.Size(184, 67);
            this.btnAutent.Text = "Autentificare";
            this.btnAutent.Click += new EventHandler(btnAutent_Click);


        }

        private void btnAutent_Click(object sender, EventArgs e)
        {

            if((txtNume.Text.Equals("Administrator")&&txtParola.Text.Equals("agentie2015")) || (txtNume.Text.Equals("Turist") &&txtParola.Text.Equals("oti2015")))
            {

                this.form.removepnl("pnlAutentificare");

            }
            else
            {
                MessageBox.Show("Nu ati introdus numele/parola!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtParola.Text = "";
                txtNume.Text = "";
            }

        }



    }
}
