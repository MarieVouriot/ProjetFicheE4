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
    
    public partial class fiche
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fiche()
        {
            this.medecin = new HashSet<medecin>();
        }
    
        public int id { get; set; }
        public int codeTheme { get; set; }
        public string titre { get; set; }
        public Nullable<double> note { get; set; }
        public double prix { get; set; }
    
        public virtual theme_fiche theme_fiche { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<medecin> medecin { get; set; }
    }
}