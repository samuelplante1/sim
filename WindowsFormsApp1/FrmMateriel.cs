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
    public partial class FrmMateriel : Form
    {
        public FrmMateriel(List<Participant> participants)
        {
            InitializeComponent();
            foreach (Participant participant in participants)
            {
                cboParticipant.Items.Add(participant.Nom);
            }
            PopulerChampsMatériel();
            PopulerChampsGroupes();
            btnEnvoi.Enabled = false;
        }

        private void PopulerChampsMatériel()
        {
            sql msql = new sql("SELECT * FROM ClubDeGo.Materiel ORDER BY 2", "A18_Sim_Eq07");
            SqlDataReader read = msql.execute();
            while (read.Read())
            {
                cboMateriel1.Items.Add(read["NomMateriel"]);
                cboMateriel2.Items.Add(read["NomMateriel"]);
                cboMateriel3.Items.Add(read["NomMateriel"]);
                cboMateriel4.Items.Add(read["NomMateriel"]);
                cboMateriel5.Items.Add(read["NomMateriel"]);
            }
            read.Close();
        }
        private void PopulerChampsGroupes()
        {
            sql msql = new sql("SELECT * FROM Participant ORDER BY 6", "A18_Sim_Eq07");
            SqlDataReader read = msql.execute();
            while (read.Read())
            {
                cboParticipant.Items.Add(read["nomGroupe"]);
            }
            read.Close();
        }
        private void cboMateriel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMateriel1.SelectedIndex != -1)
           
            {
                btnEnvoi.Enabled = true;
            }
            else
            {
                btnEnvoi.Enabled = false;
            }
        }
        private void cboMateriel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboMateriel2.SelectedIndex != -1)
            {
                btnEnvoi.Enabled = true;
            }
            else
            {
                btnEnvoi.Enabled = false;
            }
        }
        private void cboMateriel3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMateriel3.SelectedIndex != -1)
            {
                btnEnvoi.Enabled = true;
            }
            else
            {
                btnEnvoi.Enabled = false;
            }
        }
        private void cboMateriel4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMateriel4.SelectedIndex != -1)
            {
                btnEnvoi.Enabled = true;
            }
            else
            {
                btnEnvoi.Enabled = false;
            }
        }
        private void cboMateriel5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMateriel5.SelectedIndex != -1)
            {
                btnEnvoi.Enabled = true;
            }
            else
            {
                btnEnvoi.Enabled = false;
            }
        }
        private void btnEnvoi_Click(object sender, EventArgs e)
        {

            sql msql = new sql("INSERT INTO dbo.NumeroMateriel VALUES (" + (cboParticipant.SelectedIndex + 1) + "," + (cboMateriel1.SelectedIndex + 1) + "," + nUDMateriel1.Value, "A18_Sim_Eq07");
        }


    }
}
