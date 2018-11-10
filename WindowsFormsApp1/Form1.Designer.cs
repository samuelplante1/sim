namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.cmbCegep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbExistant = new System.Windows.Forms.ComboBox();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNomDuGroupe = new System.Windows.Forms.Label();
            this.lblCourriel = new System.Windows.Forms.Label();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Inscription des Participants";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(77, 124);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(183, 124);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // cmbCegep
            // 
            this.cmbCegep.FormattingEnabled = true;
            this.cmbCegep.Location = new System.Drawing.Point(586, 123);
            this.cmbCegep.Name = "cmbCegep";
            this.cmbCegep.Size = new System.Drawing.Size(125, 21);
            this.cmbCegep.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cegep";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(585, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date de l\'événement";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(74, 107);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(180, 107);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 8;
            this.lblPrenom.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Si vous faites partie d\'un groupe, indiquer le nom du groupe";
            // 
            // cmbExistant
            // 
            this.cmbExistant.FormattingEnabled = true;
            this.cmbExistant.Location = new System.Drawing.Point(300, 124);
            this.cmbExistant.Name = "cmbExistant";
            this.cmbExistant.Size = new System.Drawing.Size(247, 21);
            this.cmbExistant.TabIndex = 10;
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(585, 252);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(125, 40);
            this.btnInscrire.TabIndex = 11;
            this.btnInscrire.Text = "S\'inscrire";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(300, 204);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(247, 21);
            this.cmbCategorie.TabIndex = 12;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(297, 188);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(52, 13);
            this.lblCat.TabIndex = 13;
            this.lblCat.Text = "Catégorie";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(300, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 20);
            this.textBox2.TabIndex = 14;
            // 
            // lblNomDuGroupe
            // 
            this.lblNomDuGroupe.AutoSize = true;
            this.lblNomDuGroupe.Location = new System.Drawing.Point(297, 148);
            this.lblNomDuGroupe.Name = "lblNomDuGroupe";
            this.lblNomDuGroupe.Size = new System.Drawing.Size(82, 13);
            this.lblNomDuGroupe.TabIndex = 15;
            this.lblNomDuGroupe.Text = "Nom du Groupe";
            // 
            // lblCourriel
            // 
            this.lblCourriel.AutoSize = true;
            this.lblCourriel.Location = new System.Drawing.Point(74, 147);
            this.lblCourriel.Name = "lblCourriel";
            this.lblCourriel.Size = new System.Drawing.Size(42, 13);
            this.lblCourriel.TabIndex = 17;
            this.lblCourriel.Text = "Courriel";
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(77, 163);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(206, 20);
            this.txtCourriel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 323);
            this.Controls.Add(this.txtCourriel);
            this.Controls.Add(this.lblCourriel);
            this.Controls.Add(this.lblNomDuGroupe);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.cmbCategorie);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.cmbExistant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCegep);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ComboBox cmbCegep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbExistant;
        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Label lblCat;

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNomDuGroupe;
        private System.Windows.Forms.Label lblCourriel;
        private System.Windows.Forms.TextBox txtCourriel;
    }
}

