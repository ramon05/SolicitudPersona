using SolicitudApi.Core.BaseModel;
using SolicitudApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.BI.Dto
{
    public class TeamDto : BaseDto
    {
        public int PersonId { get; set; }
        public PersonDto Person { get; set; }
        public Status Status { get; set; }
        public DateTime CreadDate { get; set; }
    }
}
