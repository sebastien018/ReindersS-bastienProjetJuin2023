using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Intervenant : Personne
    {
        #region VARIABLES_MEMBRES
        private int _numIntervenant;
        #endregion

        #region PROPRIETES
        public int NumIntervenant
        {
            get { return _numIntervenant; }
            set { _numIntervenant = value >= 0 ? value : 0; }
        }
        #endregion

        #region CONSTRUCTEURS
        public Intervenant() : base()
        {
            _numIntervenant = 0;
        }

        public Intervenant(string nom, string prenom, string adresse, int age, int numIntervenant) : base(nom, prenom, adresse, age)
        {
            _numIntervenant = numIntervenant >= 0 ? numIntervenant : 0;
        }
        #endregion

        #region METHODES
        public override string ToString()
        {
            return base.ToString() + " " + _numIntervenant;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Intervenant autreIntervenant = (Intervenant)obj;

            return base.Equals(obj) && _numIntervenant == autreIntervenant.NumIntervenant;
        }
        #endregion
    }
}

