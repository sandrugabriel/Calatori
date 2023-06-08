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
    internal class PnlTurist:Panel
    {

        Form1 form;

        private System.Windows.Forms.Button btnValidare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbCircuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbDataStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbDataEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbPret;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbNrPasageri;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Button btnBack;

        ControllerCroaziere controllerCroaziere;
        List<Croaziere> listCroaziere;
        ControllerPorturi controllerPorturi;

        public PnlTurist(Form1 form1, List<Croaziere> croazieres) {

            form = form1;
            this.form.Size = new System.Drawing.Size(1421, 668);
            this.form.MinimumSize = new System.Drawing.Size(1421, 668);
            this.form.MaximumSize = new System.Drawing.Size(1421, 668);

            listCroaziere = croazieres;
            controllerCroaziere = new ControllerCroaziere();
            controllerPorturi = new ControllerPorturi();

            // PnlTurist
            this.Size = new System.Drawing.Size(1421, 668);
            this.Name = "PnlTurist";

            this.btnValidare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCircuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDataStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDataEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNrPasageri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.btnValidare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.lblTip);

            // btnValidare
            this.btnValidare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidare.Location = new System.Drawing.Point(1129, 423);
            this.btnValidare.Name = "btnValidare";
            this.btnValidare.Size = new System.Drawing.Size(156, 57);
            this.btnValidare.TabIndex = 7;
            this.btnValidare.Text = "Validare";
            this.btnValidare.Click += new EventHandler(btnValidare_Click);
            
            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbId,
            this.cmbCircuit,
            this.cmbDataStart,
            this.cmbDataEnd,
            this.cmbPret,
            this.cmbNrPasageri});
            this.dataGridView1.Location = new System.Drawing.Point(1, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 493);
            this.dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            for (int i = 0; i < listCroaziere.Count; i++)
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
             
            // cmbTip
            this.cmbTip.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(535, 12);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(207, 38);
            this.cmbTip.Items.Add("3 zile");
            this.cmbTip.Items.Add("5 zile");
            this.cmbTip.Items.Add("8 zile");
            this.cmbTip.SelectedIndexChanged += new EventHandler(cmbTip_SelectedIndexChanged);

            // lblTip
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblTip.Location = new System.Drawing.Point(181, 18);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(314, 32);
            this.lblTip.TabIndex = 4;
            this.lblTip.Text = "Selecteaza tipul croazierei:\r\n";
             
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblTitlu.Location = new System.Drawing.Point(1058, 113);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(307, 32);
            this.lblTitlu.TabIndex = 8;
            this.lblTitlu.Text = "Stabiliti perioada voiajului:";
            
            // lblEnd
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblEnd.Location = new System.Drawing.Point(1058, 296);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(122, 32);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "Data End:";
             
            // lblStart
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblStart.Location = new System.Drawing.Point(1058, 205);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(130, 32);
            this.lblStart.TabIndex = 10;
            this.lblStart.Text = "Data Start:";
             
            // dateTimeStart
            this.dateTimeStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.Location = new System.Drawing.Point(1058, 240);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(351, 31);
            this.dateTimeStart.ValueChanged += new EventHandler(dateTimeStart_ValueChanged);
            
            // dateTimeEnd
            this.dateTimeEnd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEnd.Location = new System.Drawing.Point(1058, 331);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(351, 31);
            this.dateTimeEnd.Enabled = false;

             
            // btnBack
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1129, 511);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 57);
            this.btnBack.TabIndex = 13;
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

        private int tip = 3;
        private string circuitul;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                DataGridViewCell circuit = selectedRow.Cells[1];

                if (circuit.Value != null)
                {
                     circuitul = circuit.Value.ToString();
                    //MessageBox.Show(circuitul);
                }
            }
        }

        private void btnValidare_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlTurist");
            this.form.Controls.Add(new PnlVizualizare(this.form,circuitul));

        }



        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTip.SelectedItem.ToString().Equals("3 zile"))
            {

                listCroaziere.Clear();
                listCroaziere = controllerCroaziere.getCroaziereTip(3);
                tip = 3;

            }
            else if (cmbTip.SelectedItem.ToString() == "5 zile")
            {

                listCroaziere.Clear();
                listCroaziere = controllerCroaziere.getCroaziereTip(5);
                tip = 5;
            }
            else
            {
                listCroaziere.Clear();
                listCroaziere = controllerCroaziere.getCroaziereTip(8);
                tip = 8;
            }

            this.form.removepnl("PnlTurist");
            this.form.Controls.Add(new PnlTurist(form, listCroaziere));
        }

        private void dateTimeStart_ValueChanged(object sender, EventArgs e)
        {

            listCroaziere.Clear();
            listCroaziere = controllerCroaziere.getCroaziereTipDate(tip, dateTimeStart.Value);
            dateTimeEnd.Value = dateTimeStart.Value.AddDays(tip);

            dataGridView1.Refresh();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlTurist");
            this.form.Controls.Add(new PnlAutentificarea(this.form));

        }

    }
}
