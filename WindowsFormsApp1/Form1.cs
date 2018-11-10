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
        private Participant m_objParticipant;
        private Cegep m_objCegep;
        private List<Participant> m_listParticipant = new List<Participant>();
        public Form1()
        {
            InitializeComponent();
            PopulerChampsCegeps();
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

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            m_objPersonne = new Personne(txtNom.Text, txtPrenom.Text, txtCourriel.Text);
            if (cmbExistant.SelectedIndex != -1)
            {
                foreach (Participant participant in m_listParticipant)
                {
                    if (participant.Nom == txtGroupe.Text)
                        participant.Ajouter(m_objPersonne);
                }
            } else
            {
                m_objParticipant = new Participant(txtGroupe.Text);
                m_listParticipant.Add(m_objParticipant);
                m_objParticipant.Ajouter(m_objPersonne);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMateriel frm = new FrmMateriel(m_listParticipant);
            frm.Show();
        }
    }
}
