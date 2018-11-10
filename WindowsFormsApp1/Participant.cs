using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Participant
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

        private List<Personne> m_colPersonnes;
        public List<Personne> ColPersonnes
        {
            get
            {
                return m_colPersonnes;
            }
        }
        #endregion

    #region CONSTRUCTEURS
        public Participant(string pNom)
        {
            nom = pNom;
            m_colPersonnes = new List<Personne>();
        }
    #endregion
    }
}
