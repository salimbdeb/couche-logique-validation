using LY01.Demandes.Domaine.Dto;
using System.Collections.Generic;

namespace LY01.Demandes.Domaine
{
    public class DateReceptionRequisValidateur
    {
        public List<Erreur> ResultasErreurs { get; set; }

        public List<Erreur> TraiterValidation(Demande demande)
        {
            Erreur erreur;
            if (demande.dateCreation == System.DateTime.MinValue)
            {
                erreur = new Erreur();
                erreur.codeErreur = "ly-002";
                erreur.champFormulaire = "Date de reception demande";
                erreur.description = "La date de reception ne doit pas etre inferieur a la date du jour";
                ResultasErreurs.Add(erreur);
            }
            return ResultasErreurs;
        }

    }
    
}
