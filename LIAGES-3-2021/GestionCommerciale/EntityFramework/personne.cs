//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionCommerciale.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class personne
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string telephone { get; set; }
        public string address { get; set; }
        public Nullable<int> Commande_id { get; set; }
        public string login { get; set; }
        public string pwd { get; set; }

        internal int CompareTo(string v)
        {
            throw new NotImplementedException();
        }
    }
}
