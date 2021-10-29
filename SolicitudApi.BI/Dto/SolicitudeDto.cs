using SolicitudApi.Core.BaseModel;
using SolicitudApi.Core.Enums;
using SolicitudApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.BI.Dto
{
    public class SolicitudeDto : BaseDto
    {
        public Status StatusName { get; set; }
        public DateTime CreadDate { get; set; }
        public int PersonId { get; set; }
        public Person PersonDto { get; set; }
    }
}
