using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class materiel
    {
        private string m_nomMateriel;
        private int m_tempsInspection;
        private bool m_estInspecte;

        /// <summary>
        /// Nom du materiel
        /// </summary>
        public string NomMateriel
        {
            get;set;
        }
        /// <summary>
        /// temps requis pour l'inspection du matériel
        /// </summary>
        public string TempsInspection
        {
            get; set;
        }
        /// <summary>
        /// Détermine si le matériel a été inspecté
        /// </summary>
        public string EstInspecte
        {
            get; set;
        }

        #region constructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        public materiel()
        {

        }
        #endregion
    }
}
