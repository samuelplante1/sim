using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cegep
    {
        #region CHAMP ET PROPRIÉTÉS
        private string m_nom;
        /// <summary>
        /// Le nom du CEGEP
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

        private string m_adresse;
        /// <summary>
        /// L'adresse du CEGEP
        /// </summary>
        public string Adresse
        {
            get
            {
                return m_adresse;
            }
            set
            {
                m_adresse = value;
            }
        }
        #endregion
        #region CONSCTRUCTEUR
        public Cegep(string pNom, string pAdresse)
        {
            Nom = pNom;
            Adresse = pAdresse;
        }
        #endregion
    }
}
