using SolicitudApi.Core.BaseModel;
using SolicitudApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Model.Entities
{
    public class Solicitude : Base
    {
        public Status StatusName { get; set; }
        public string CreadDate { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
