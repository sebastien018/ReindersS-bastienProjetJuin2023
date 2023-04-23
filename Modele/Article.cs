using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Article
    {
        #region VARIABLES_MEMBRES
        private string _designation;
        private int _quantite;
        private float _prix;
        #endregion

        #region PROPRIETES
        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }

        public int Quantite
        {
            get { return _quantite; }
            set { _quantite = value; }
        }

        public float Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }
        #endregion

        #region CONSTRUCTEURS
        public Article()
        {
            _designation = "Nike default";
            _quantite = 0;
            _prix = 0.0f;
        }

        public Article(string designation, int quantite, float prix)
        {
            _designation = designation;
            _quantite = quantite;
            _prix = prix;
        }
        #endregion

        #region METHODES
        public override string ToString()
        {
            return _designation + " " + _quantite + " " + _prix;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Article autreArticle = obj as Article;

            if (autreArticle == null)
                return false;

            return _designation == autreArticle.Designation && _quantite == autreArticle.Quantite && _prix == autreArticle.Prix;
        }
        #endregion
    }
}
