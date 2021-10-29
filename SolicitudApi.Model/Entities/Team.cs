using SolicitudApi.Core.BaseModel;
using SolicitudApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Model.Entities
{
    public class Team : Base
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public Status Status { get; set; }
        public string CreadDate { get; set; }
    }
}
