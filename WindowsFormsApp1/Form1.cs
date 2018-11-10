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
    }
}
