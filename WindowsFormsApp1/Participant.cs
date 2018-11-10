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
        /// <summary>
        /// Le nom de l'individuel ou du groupe qui participe au concours
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

        private List<Personne> m_colPersonnes;
        /// <summary>
        /// Liste de personne dans le participants
        /// </summary>
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
            Nom = pNom;
            m_colPersonnes = new List<Personne>();
        }
        #endregion
        #region Méthodes
        /// <summary>
        /// Ajoute une nouvelle personne à la liste
        /// </summary>
        public void Ajouter(Personne pPersonne)
        {
            m_colPersonnes.Add(pPersonne);
        }
        #endregion
    }
}
