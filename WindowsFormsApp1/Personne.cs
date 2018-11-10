using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Personne
    {
        #region CHAMPS ET PROPRIÉTÉS
        private string m_nom;
        public string nom
        {
            get
            {
                return m_nom;
            }

            set
            {
                m_nom = value;
            }
        }

        private string m_prenom;

        public string prenom
        {
            get
            {
                return m_prenom;
            }
            set
            {
                m_prenom = value;
            }
        }

        private string m_courriel;

        public string courriel
        {
            get
            {
                return m_courriel;
            }
            set
            {
                m_courriel = value;
            }
        }
        #endregion
        #region CONSTRUCTEUR
        public Personne(string pNom, string pPrenom, string pCourriel)
        {
            nom = pNom;
            prenom = pPrenom;
            courriel = pCourriel;
        }
        #endregion
    }
}
