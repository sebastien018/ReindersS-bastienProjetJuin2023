using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Client : Intervenant
    {
        #region VARIABLES_MEMBRES
        private int _points;
        private string _numTel;
        #endregion

        #region PROPRIETES
        public int Points
        {
            get { return _points; }
            set { _points = value >= 0 ? value : 0; }
        }

        public string NumTel
        {
            get { return _numTel; }
            set { _numTel = value; }
        }
        #endregion

        #region CONSTRUCTEURS
        public Client() : base()
        {
            _points = 0;
            _numTel = "";
        }

        public Client(string nom, string prenom, string adresse, int age, int numIntervenant, int points, string numTel) : base(nom, prenom, adresse, age, numIntervenant)
        {
            _points = points >= 0 ? points : 0;
            _numTel = numTel;
        }
        #endregion

        #region METHODES
        public override string ToString()
        {
            return base.ToString() + " " + _points + " " + _numTel;
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;

            Client autreClient = obj as Client;

            if (autreClient == null)
                return false;

            return _points == autreClient.Points && _numTel == autreClient.NumTel;
        }
        #endregion
    }
}

