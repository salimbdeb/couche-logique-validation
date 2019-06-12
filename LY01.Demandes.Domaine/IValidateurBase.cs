using LY01.Demandes.Domaine.Dto;
using System.Collections.Generic;

namespace LY01.Demandes.Domaine
{
    public interface IValidateurBase
    {
         List<Erreur> ResultasErreurs { get; set; }
         List<Erreur> TraiterValidation(Demande demande);
        
    }
}