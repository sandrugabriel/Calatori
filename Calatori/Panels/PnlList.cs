using Calatori.Controllers;
using Calatori.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calatori.Panels
{
    internal class PnlList:Panel
    {

        Form1 form;

        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbDataStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbDataEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbPret;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbNrPasageri;
        private System.Windows.Forms.Button btnBack;

        
        List<Croaziere> listCroaziere;
        ControllerCroaziere controllerCroaziere;
        ControllerPorturi controllerPorturi;
        string text = null;

        public PnlList(Form1 form1, List<Croaziere> croazieres)
        {


            form = form1;
            this.form.Size = new System.Drawing.Size(1328, 891);
            this.form.MinimumSize = new System.Drawing.Size(1328, 891);
            this.form.MaximumSize = new System.Drawing.Size(1328, 891);

            controllerCroaziere = new ControllerCroaziere();
            controllerPorturi = new ControllerPorturi();
            listCroaziere = controllerCroaziere.getCroaziere();


            // pnlLista
            this.Size = new System.Drawing.Size(1128, 691);
            this.Name = "PnlLista";

            this.lblTip = new System.Windows.Forms.Label();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDataStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDataEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNrPasageri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.lblTip);

            // lblTip
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblTip.Location = new System.Drawing.Point(56, 23);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(314, 32);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "Selecteaza tipul croazierei:\r\n";
             
            // cmbTip
            this.cmbTip.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(399, 23);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(207, 38);
            this.cmbTip.Items.Add("3 zile");
            this.cmbTip.Items.Add("5 zile");
            this.cmbTip.Items.Add("8 zile");
            this.cmbTip.SelectedIndexChanged += new EventHandler(cmbTip_SelectedIndexChanged);
             
            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbId,
            this.cmbCircuit,
            this.cmbDataStart,
            this.cmbDataEnd,
            this.cmbPret,
            this.cmbNrPasageri});
            this.dataGridView1.Location = new System.Drawing.Point(24, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 523);
            this.dataGridView1.TabIndex = 2;
             
            for(int i = 0; i < listCroaziere.Count; i++)
            {

                dataGridView1.Rows.Add(listCroaziere[i].getId(), getText(i), listCroaziere[i].getDataStart(), listCroaziere[i].getDataEnd(), listCroaziere[i].getPret(), listCroaziere[i].getNumPasageri());

            }

            // cmbId
            this.cmbId.HeaderText = "Id";
            this.cmbId.MinimumWidth = 6;
            this.cmbId.Name = "cmbId";
            this.cmbId.ReadOnly = true;
            this.cmbId.Width = 70;
             
            // cmbCircuit
            this.cmbCircuit.FillWeight = 350F;
            this.cmbCircuit.HeaderText = "Circuit";
            this.cmbCircuit.MinimumWidth = 6;
            this.cmbCircuit.Name = "cmbCircuit";
            this.cmbCircuit.ReadOnly = true;
            this.cmbCircuit.Width = 400;
             
            // cmbDataStart
            this.cmbDataStart.HeaderText = "Data Start";
            this.cmbDataStart.MinimumWidth = 6;
            this.cmbDataStart.Name = "cmbDataStart";
            this.cmbDataStart.ReadOnly = true;
            this.cmbDataStart.Width = 125;
            
            // cmbDataEnd
            this.cmbDataEnd.HeaderText = "Data End";
            this.cmbDataEnd.MinimumWidth = 6;
            this.cmbDataEnd.Name = "cmbDataEnd";
            this.cmbDataEnd.ReadOnly = true;
            this.cmbDataEnd.Width = 125;
             
            // cmbPret
            this.cmbPret.HeaderText = "Pret";
            this.cmbPret.MinimumWidth = 6;
            this.cmbPret.Name = "cmbPret";
            this.cmbPret.ReadOnly = true;
            this.cmbPret.Width = 125;
             
            // cmbNrPasageri
            this.cmbNrPasageri.HeaderText = "Nr. Pasageri";
            this.cmbNrPasageri.MinimumWidth = 6;
            this.cmbNrPasageri.Name = "cmbNrPasageri";
            this.cmbNrPasageri.ReadOnly = true;
            this.cmbNrPasageri.Width = 125;
             
            // btnBack
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(950, 622);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 57);
            this.btnBack.Text = "Inchidere";
            this.btnBack.Click += new EventHandler(btnBack_Click);


        }

        public string getText(int k)
        {
            string text = null;
            List<int> list = listCroaziere[k].getListPorturi();
            for (int i = 0; i < list.Count; i++)
            {
                text += controllerPorturi.namebyId(list[i]) + ",";
            }

            return text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlLista");
            this.form.Controls.Add(new PnlAutentificarea(this.form));

        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTip.SelectedItem.ToString().Equals("3 zile")) {

                listCroaziere.Clear();
                listCroaziere = controllerCroaziere.getCroaziereTip(3);

            }
            else if (cmbTip.SelectedItem.ToString() == "5 zile")
            {

                listCroaziere.Clear();
                listCroaziere = controllerCroaziere.getCroaziereTip(5);

            }
            else
            {
                listCroaziere.Clear();
                listCroaziere = controllerCroaziere.getCroaziereTip(8);

            }

            this.form.removepnl("PnlLista");
            this.form.Controls.Add(new PnlList(form, listCroaziere));
        }


    }
}
