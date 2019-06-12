using LY01.Demandes.Domaine.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LY01.Demandes.Domaine
{
    public class ContexteValidationDemande : IValidationDemande
    {
        public  List<Erreur> Valider(Demande dto)
        {
            DateCreationRequisValidateur dateCreationRequisValidateur = new DateCreationRequisValidateur();
            DateReceptionRequisValidateur dateReceptionRequisValidateur = new DateReceptionRequisValidateur();
            //dateFromRequiredValidator.SetSuccessor(dateFromRangeValidator);
            //DateToRequiredValidator dateTimeToRequiredValidator = new DateToRequiredValidator();
            //dateFromRangeValidator.SetSuccessor(dateTimeToRequiredValidator);
            //DateToRangeValidator dateToRangeValidator = new DateToRangeValidator();
            //dateTimeToRequiredValidator.SetSuccessor(dateToRangeValidator);
            //ApartmentAvaliableValidator apartmentAvaliableValidator = new ApartmentAvaliableValidator();
            //dateToRangeValidator.SetSuccessor(apartmentAvaliableValidator);

            return dateCreationRequisValidateur.ResultasErreurs;
        }
    }
}
