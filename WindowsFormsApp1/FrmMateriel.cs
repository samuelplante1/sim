using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            foreach(Participant participant in participants)
            {
                cboParticipant.Items.Add(participant.Nom);
            }
            InitializeComponent();
        }

 
    }
}
