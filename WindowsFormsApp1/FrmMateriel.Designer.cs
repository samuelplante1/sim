namespace WindowsFormsApp1
{
    partial class FrmMateriel
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
            this.cboParticipant = new System.Windows.Forms.ComboBox();
            this.lblNomParticipant = new System.Windows.Forms.Label();
            this.lblMétériel = new System.Windows.Forms.Label();
            this.cboMateriel1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDMateriel1 = new System.Windows.Forms.NumericUpDown();
            this.cboMateriel2 = new System.Windows.Forms.ComboBox();
            this.cboMateriel3 = new System.Windows.Forms.ComboBox();
            this.nUDMateriel12 = new System.Windows.Forms.NumericUpDown();
            this.nUDMateriel13 = new System.Windows.Forms.NumericUpDown();
            this.btnEnvoi = new System.Windows.Forms.Button();
            this.cboMateriel4 = new System.Windows.Forms.ComboBox();
            this.cboMateriel5 = new System.Windows.Forms.ComboBox();
            this.nUDMateriel14 = new System.Windows.Forms.NumericUpDown();
            this.nUDMateriel15 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMateriel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMateriel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMateriel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMateriel14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMateriel15)).BeginInit();
            this.SuspendLayout();
            // 
            // cboParticipant
            // 
            this.cboParticipant.FormattingEnabled = true;
            this.cboParticipant.Location = new System.Drawing.Point(62, 47);
            this.cboParticipant.Name = "cboParticipant";
            this.cboParticipant.Size = new System.Drawing.Size(204, 21);
            this.cboParticipant.TabIndex = 0;
            // 
            // lblNomParticipant
            // 
            this.lblNomParticipant.AutoSize = true;
            this.lblNomParticipant.Location = new System.Drawing.Point(59, 22);
            this.lblNomParticipant.Name = "lblNomParticipant";
            this.lblNomParticipant.Size = new System.Drawing.Size(57, 13);
            this.lblNomParticipant.TabIndex = 1;
            this.lblNomParticipant.Text = "Participant";
            // 
            // lblMétériel
            // 
            this.lblMétériel.AutoSize = true;
            this.lblMétériel.Location = new System.Drawing.Point(59, 97);
            this.lblMétériel.Name = "lblMétériel";
            this.lblMétériel.Size = new System.Drawing.Size(44, 13);
            this.lblMétériel.TabIndex = 2;
            this.lblMétériel.Text = "Matériel";
            // 
            // cboMateriel1
            // 
            this.cboMateriel1.FormattingEnabled = true;
            this.cboMateriel1.Location = new System.Drawing.Point(62, 126);
            this.cboMateriel1.Name = "cboMateriel1";
            this.cboMateriel1.Size = new System.Drawing.Size(204, 21);
            this.cboMateriel1.TabIndex = 3;
            this.cboMateriel1.SelectedIndexChanged += new System.EventHandler(this.cboMateriel1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // nUDMateriel1
            // 
            this.nUDMateriel1.Location = new System.Drawing.Point(297, 126);
            this.nUDMateriel1.Name = "nUDMateriel1";
            this.nUDMateriel1.Size = new System.Drawing.Size(120, 20);
            this.nUDMateriel1.TabIndex = 6;
            // 
            // cboMateriel2
            // 
            this.cboMateriel2.FormattingEnabled = true;
            this.cboMateriel2.Location = new System.Drawing.Point(62, 162);
            this.cboMateriel2.Name = "cboMateriel2";
            this.cboMateriel2.Size = new System.Drawing.Size(204, 21);
            this.cboMateriel2.TabIndex = 7;
            // 
            // cboMateriel3
            // 
            this.cboMateriel3.FormattingEnabled = true;
            this.cboMateriel3.Location = new System.Drawing.Point(62, 202);
            this.cboMateriel3.Name = "cboMateriel3";
            this.cboMateriel3.Size = new System.Drawing.Size(204, 21);
            this.cboMateriel3.TabIndex = 8;
            // 
            // nUDMateriel12
            // 
            this.nUDMateriel12.Location = new System.Drawing.Point(297, 163);
            this.nUDMateriel12.Name = "nUDMateriel12";
            this.nUDMateriel12.Size = new System.Drawing.Size(120, 20);
            this.nUDMateriel12.TabIndex = 9;
            // 
            // nUDMateriel13
            // 
            this.nUDMateriel13.Location = new System.Drawing.Point(297, 202);
            this.nUDMateriel13.Name = "nUDMateriel13";
            this.nUDMateriel13.Size = new System.Drawing.Size(120, 20);
            this.nUDMateriel13.TabIndex = 10;
            // 
            // btnEnvoi
            // 
            this.btnEnvoi.Location = new System.Drawing.Point(654, 387);
            this.btnEnvoi.Name = "btnEnvoi";
            this.btnEnvoi.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoi.TabIndex = 11;
            this.btnEnvoi.Text = "Envoyé";
            this.btnEnvoi.UseVisualStyleBackColor = true;
            // 
            // cboMateriel4
            // 
            this.cboMateriel4.FormattingEnabled = true;
            this.cboMateriel4.Location = new System.Drawing.Point(62, 242);
            this.cboMateriel4.Name = "cboMateriel4";
            this.cboMateriel4.Size = new System.Drawing.Size(204, 21);
            this.cboMateriel4.TabIndex = 12;
            // 
            // cboMateriel5
            // 
            this.cboMateriel5.FormattingEnabled = true;
            this.cboMateriel5.Location = new System.Drawing.Point(62, 281);
            this.cboMateriel5.Name = "cboMateriel5";
            this.cboMateriel5.Size = new System.Drawing.Size(204, 21);
            this.cboMateriel5.TabIndex = 13;
            // 
            // nUDMateriel14
            // 
            this.nUDMateriel14.Location = new System.Drawing.Point(297, 243);
            this.nUDMateriel14.Name = "nUDMateriel14";
            this.nUDMateriel14.Size = new System.Drawing.Size(120, 20);
            this.nUDMateriel14.TabIndex = 14;
            // 
            // nUDMateriel15
            // 
            this.nUDMateriel15.Location = new System.Drawing.Point(297, 281);
            this.nUDMateriel15.Name = "nUDMateriel15";
            this.nUDMateriel15.Size = new System.Drawing.Size(120, 20);
            this.nUDMateriel15.TabIndex = 15;
            // 
            // FrmMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nUDMateriel15);
            this.Controls.Add(this.nUDMateriel14);
            this.Controls.Add(this.cboMateriel5);
            this.Controls.Add(this.cboMateriel4);
            this.Controls.Add(this.btnEnvoi);
            this.Controls.Add(this.nUDMateriel13);
            this.Controls.Add(this.nUDMateriel12);
            this.Controls.Add(this.cboMateriel3);
            this.Controls.Add(this.cboMateriel2);
            this.Controls.Add(this.nUDMateriel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMateriel1);
            this.Controls.Add(this.lblMétériel);
            this.Controls.Add(this.lblNomParticipant);
            this.Controls.Add(this.cboParticipant);
            this.Name = "FrmMateriel";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nUDMateriel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMateriel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMateriel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMateriel14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMateriel15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboParticipant;
        private System.Windows.Forms.Label lblNomParticipant;
        private System.Windows.Forms.Label lblMétériel;
        private System.Windows.Forms.ComboBox cboMateriel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDMateriel1;
        private System.Windows.Forms.ComboBox cboMateriel2;
        private System.Windows.Forms.ComboBox cboMateriel3;
        private System.Windows.Forms.NumericUpDown nUDMateriel12;
        private System.Windows.Forms.NumericUpDown nUDMateriel13;
        private System.Windows.Forms.Button btnEnvoi;
        private System.Windows.Forms.ComboBox cboMateriel4;
        private System.Windows.Forms.ComboBox cboMateriel5;
        private System.Windows.Forms.NumericUpDown nUDMateriel14;
        private System.Windows.Forms.NumericUpDown nUDMateriel15;
    }
}