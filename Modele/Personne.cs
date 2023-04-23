using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Personne
    {
        #region VARIABLES_MEMBRES
        private string _nom;
        private string _prenom;
        private string _adresse;
        private int _age;
        #endregion

        #region PROPRIETES
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value >= 0 ? value : 0; }
        }
        #endregion

        #region CONSTRUCTEURS
        public Personne()
        {
            _nom = "default";
            _prenom = "default";
            _adresse = "default";
            _age = 0;
        }

        public Personne(string nom, string prenom, string adresse, int age)
        {
            _nom = nom;
            _prenom = prenom;
            _adresse = adresse;
            _age = age >= 0 ? age : 0;
        }

        #endregion

        #region METHODES
        public override string ToString()
        {
            return _nom + " " + _prenom + " " + _adresse + " " + _age;
        }

        public override bool Equals(object obj)
        {
            // Vérification que l'objet passé en paramètre est bien une Personne
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // Conversion de l'objet passé en paramètre en Personne
            Personne autrePersonne = (Personne)obj;

            // Comparaison des propriétés Nom, Prenom, Adresse et Age
            return _nom == autrePersonne.Nom &&
                   _prenom == autrePersonne.Prenom &&
                   _adresse == autrePersonne.Adresse &&
                   _age == autrePersonne.Age;
        }

        #endregion

    }
}
