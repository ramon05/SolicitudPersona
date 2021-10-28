using SolicitudApi.Core.BaseModel;
using SolicitudApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.BI.Dto
{
    public class SolicitudeDto : BaseDto
    {
        public Status StatusName { get; set; }
        public string CreadDate { get; set; }
    }
}
