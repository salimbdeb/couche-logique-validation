using System;
using System.Collections.Generic;
using System.Text;

namespace LY01.Demandes.Domaine.Dto
{
    public class Demande
    {
        public string numero { get; set; }
        public string nature { get; set; }
        public string provenance { get; set; }
        public DateTime dateCreation { get; set; }
        public DateTime dateReception { get; set; }
    }
}
