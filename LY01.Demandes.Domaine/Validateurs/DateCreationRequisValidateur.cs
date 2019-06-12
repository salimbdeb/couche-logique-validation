using System.Collections.Generic;
using LY01.Demandes.Domaine.Dto;

namespace LY01.Demandes.Domaine
{
    public class DateCreationRequisValidateur : IValidateurBase
    {
        public List<Erreur> ResultasErreurs { get ; set; }

        public  List<Erreur> TraiterValidation(Demande demande)
        {
            Erreur erreur;
            if (demande.dateCreation == System.DateTime.MinValue)
            {
                erreur = new Erreur();
                erreur.codeErreur = "ly-001";
                erreur.champFormulaire = "Date de creation demande";
                erreur.description = "La date de creation ne doit pas etre inferieur a la date du jour";
                ResultasErreurs.Add(erreur);
            }

            return ResultasErreurs;
            
        }
    }
}