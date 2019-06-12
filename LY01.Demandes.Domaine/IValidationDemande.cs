using LY01.Demandes.Domaine.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LY01.Demandes.Domaine
{
    public interface IValidationDemande
    {
        List<Erreur> Valider(Demande dto);
    }
}
