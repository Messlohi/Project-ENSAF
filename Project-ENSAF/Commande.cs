//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_ENSAF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Commande
    {
        public int NCommande { get; set; }
        public int quantite { get; set; }
        public System.DateTime dateDemande { get; set; }
        public System.DateTime dateArrive { get; set; }
        public decimal prixGrossiere { get; set; }
        public int idFournisseur { get; set; }
        public int codeMagazin { get; set; }
        public int codeProduit { get; set; }
    
        public virtual Fournisseur Fournisseur { get; set; }
        public virtual Magazin Magazin { get; set; }
        public virtual Produit Produit { get; set; }
    }
}