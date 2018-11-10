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
        /// <summary>
        /// Le nom de famille de la personne
        /// </summary>
        public string Nom
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
        /// <summary>
        /// Le prénom de la personne
        /// </summary>
        public string Prenom
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
        /// <summary>
        /// Le courriel de la personne
        /// </summary>
        public string Courriel
        {
            get
            {
                return m_courriel;
            }
            set
            {
                if (value.Contains('@'))
                {
                    m_courriel = value;
                }
                else
                {
                    throw new ArgumentException();
                }
                
            }
        }
        #endregion
        #region CONSTRUCTEUR
        public Personne(string pNom, string pPrenom, string pCourriel)
        {
            Nom = pNom;
            Prenom = pPrenom;
            Courriel = pCourriel;
        }
        #endregion
    }
}
