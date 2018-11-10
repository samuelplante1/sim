using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Personne m_objPersonne;
        private List<Personne> m_listPersonnes;
        private Participant m_objParticipant;
        private Cegep m_objCegep;
        private List<Participant> m_listParticipant = new List<Participant>();
        public Form1()
        {
            InitializeComponent();

            m_listPersonnes = new List<Personne>();
            PopulerChampsCegeps();
            PopulerChampsGroupes();
            PopulerChampsCategories();
        }
        List<Cegep> listCegep;


        private void PopulerChampsCegeps()
        {
            sql msql = new sql("SELECT * FROM Cegep ORDER BY 3", "A18_Sim_Eq07");
            SqlDataReader read = msql.execute();
            while (read.Read())
            {
                cmbCegep.Items.Add(read["nomCegep"]);
            }
            read.Close();
        }

        private void PopulerChampsGroupes()
        {
            cmbGroupesExistants.Items.Add("Aucun");
            cmbGroupesExistants.SelectedIndex = 0;
            sql msql = new sql("SELECT * FROM Participant ORDER BY 6", "A18_Sim_Eq07");
            SqlDataReader read = msql.execute();
            while (read.Read())
            {
                cmbGroupesExistants.Items.Add(read["nomGroupe"]);
            }
            read.Close();
        }

        private void PopulerChampsCategories()
        {
            sql msql = new sql("SELECT * FROM Categorie ORDER BY 2", "A18_Sim_Eq07");
            SqlDataReader read = msql.execute();
            while (read.Read())
            {
                cmbCategorie.Items.Add(read["NomCategorie"]);
            }
            read.Close();
        }

        //private void ChargerPersonnes()
        //{
        //    sql msql = new sql("SELECT * FROM Personne ORDER BY 2, 3", "A18_Sim_Eq07");
        //    SqlDataReader read = msql.execute();
        //    while (read.Read())
        //    {
        //        m_listPersonnes.Add(new Personne(read["nomCegep"]));
        //    }
        //    read.Close();
        //}

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            if(txtNom.Text != "" && txtPrenom.Text != "" && txtCourriel.Text != "" && cmbCategorie.SelectedIndex != -1 && cmbCegep.SelectedIndex != -1)
            {
                sql insertionPersonneSQL = new sql("INSERT INTO [dbo].[Personne] VALUES ('" +  txtPrenom.Text + "', '" + txtNom.Text +  "', '" + txtCourriel.Text + "', " + "123123" + ")", "A18_Sim_Eq07");
                insertionPersonneSQL.executeNonQuery();

                sql insertioInscriptionnSQL = new sql("INSERT INTO [dbo].[Inscription] VALUES ()", "A18_Sim_Eq07");
                insertioInscriptionnSQL.executeNonQuery();


                // Ajouter à la liste locale
                m_objPersonne = new Personne(txtNom.Text, txtPrenom.Text, txtCourriel.Text);
                if (cmbGroupesExistants.SelectedIndex != -1)
                {
                    foreach (Participant participant in m_listParticipant)
                    {
                        if (participant.Nom == txtGroupe.Text)
                        {
                            participant.Ajouter(m_objPersonne);
                        }
                    }
                }
                else
                {
                    m_objParticipant = new Participant(txtGroupe.Text);
                    m_listParticipant.Add(m_objParticipant);
                    m_objParticipant.Ajouter(m_objPersonne);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMateriel frm = new FrmMateriel(m_listParticipant);
            frm.Show();
        }

        private void cmbGroupesExistants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGroupesExistants.SelectedIndex > 0)
            {
                txtGroupe.Text = "";
                txtGroupe.Enabled = false;
            }
            else
            {
                txtGroupe.Enabled = true;
            }
        }
        //private void VerifierIns
    }
}
