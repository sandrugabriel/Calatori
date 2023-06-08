namespace Calatori.Mockups
{
    partial class PnlListCroaziera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctImg = new System.Windows.Forms.PictureBox();
            this.btnInitializare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnGenerare = new System.Windows.Forms.Button();
            this.btnListCroaziere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pctImg
            // 
            this.pctImg.Location = new System.Drawing.Point(24, 58);
            this.pctImg.Name = "pctImg";
            this.pctImg.Size = new System.Drawing.Size(1027, 624);
            this.pctImg.TabIndex = 0;
            this.pctImg.TabStop = false;
            // 
            // btnInitializare
            // 
            this.btnInitializare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitializare.Location = new System.Drawing.Point(1098, 99);
            this.btnInitializare.Name = "btnInitializare";
            this.btnInitializare.Size = new System.Drawing.Size(237, 49);
            this.btnInitializare.TabIndex = 1;
            this.btnInitializare.Text = "Initializare";
            this.btnInitializare.UseVisualStyleBackColor = true;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.Location = new System.Drawing.Point(1098, 180);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(237, 49);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare coordonate";
            this.btnSalvare.UseVisualStyleBackColor = true;
            // 
            // btnActualizare
            // 
            this.btnActualizare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizare.Location = new System.Drawing.Point(1098, 326);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(237, 49);
            this.btnActualizare.TabIndex = 3;
            this.btnActualizare.Text = "Actualizare distante";
            this.btnActualizare.UseVisualStyleBackColor = true;
            // 
            // btnGenerare
            // 
            this.btnGenerare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerare.Location = new System.Drawing.Point(1098, 451);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(237, 49);
            this.btnGenerare.TabIndex = 4;
            this.btnGenerare.Text = "Generare croaziere";
            this.btnGenerare.UseVisualStyleBackColor = true;
            // 
            // btnListCroaziere
            // 
            this.btnListCroaziere.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCroaziere.Location = new System.Drawing.Point(1098, 519);
            this.btnListCroaziere.Name = "btnListCroaziere";
            this.btnListCroaziere.Size = new System.Drawing.Size(237, 49);
            this.btnListCroaziere.TabIndex = 5;
            this.btnListCroaziere.Text = "Lista Croaziere";
            this.btnListCroaziere.UseVisualStyleBackColor = true;
            // 
            // PnlListCroaziera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 703);
            this.Controls.Add(this.btnListCroaziere);
            this.Controls.Add(this.btnGenerare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnInitializare);
            this.Controls.Add(this.pctImg);
            this.Name = "PnlListCroaziera";
            this.Text = "PnlListCroaziera";
            ((System.ComponentModel.ISupportInitialize)(this.pctImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImg;
        private System.Windows.Forms.Button btnInitializare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnGenerare;
        private System.Windows.Forms.Button btnListCroaziere;
    }
}