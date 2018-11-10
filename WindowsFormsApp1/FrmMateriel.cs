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

        private void cboMateriel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMateriel1.SelectedIndex != -1 ||
                cboMateriel2.SelectedIndex != -1 ||
                cboMateriel3.SelectedIndex != -1 ||
                cboMateriel4.SelectedIndex != -1 ||
                cboMateriel5.SelectedIndex != -1 )
            {
                btnEnvoi.Enabled = true;
            }
            else
            {
                btnEnvoi.Enabled = false;
            }
        }
    }
}
