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
    public partial class Form1 : Form
    {
        private Personne m_objPersonne;
        private Cegep m_objCegep;
        public Form1()
        {
            InitializeComponent();
            PopulerChampsCegeps();
        }
        List<Cegep> listCegep;


        private void PopulerChampsCegeps()
        {
            throw new NotImplementedException();
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            m_objPersonne = new Personne(txtNom.Text, txtPrenom.Text, txtCourriel.Text);
        }
    }
}
