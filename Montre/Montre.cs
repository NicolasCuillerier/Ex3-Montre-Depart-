using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationMontre
{ 
  // TODO 02 : En vous référant au diagramme "Ex3 Montre.png" compléter le code de la classe Montre
  // - Rappel : Les constructeurs doivent initialiser tous les champs.
  // - La méthode AvancerUneSeconde() augmente le temps courant d'une seconde et ajuste les heures, minutes et secondes
  //   en conséquence. Par exemple s'il est 23:59:59 le temps courant deviendra 00:00:00
  // - La méthode ObtenirTempsCourant() retourne une chaîne avec les heures, les minutes et les secondes.
  //   Par exemple "23:59:59". Utiliser au besoin ToString("00") 
    class Montre
    {
        private int m_heures;
        private int m_minutes;
        private int m_secondes;
        public int Heures
        {
            get { return m_heures; }
        }
        public int Minutes
        {
            get { return m_minutes; }
        }
        public int Secondes
        {
            get { return m_secondes; }
        }
        public void AvancerUneSeconde()
        {
            m_secondes++;
            if (m_secondes == 60)
            {
                m_secondes = 0;
                m_minutes++;
                if (m_minutes == 60)
                {
                    m_minutes = 0;
                    m_heures++;
                    if (m_heures==24)
                    {
                        m_heures = 0;
                    }
                }
            }
        }
        public Montre()
        {
            m_secondes = 0;
            m_minutes = 0;
            m_heures = 0;
        }
        public Montre(int pHeures,int pMinutes, int pSecondes)
        {
            m_heures = pHeures;
            m_minutes = pMinutes;
            m_secondes = pSecondes;
        }
        public string ObtenirTempsCourant()
        {
            return Heures.ToString("00") + ":" + Minutes.ToString("00") + ":" + Secondes.ToString("00");
        }
    }
}
