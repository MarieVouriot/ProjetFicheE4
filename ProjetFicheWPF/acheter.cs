//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetFicheWPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class acheter
    {
        public int numEtudiant { get; set; }
        public int idFiche { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual etudiant etudiant { get; set; }
        public virtual fiche fiche { get; set; }
    }
}
