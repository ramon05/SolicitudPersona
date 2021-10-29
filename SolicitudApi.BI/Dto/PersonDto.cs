using SolicitudApi.Core.BaseModel;
using SolicitudApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.BI.Dto
{
    public class PersonDto : BaseDto
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Bob { get; set; }
        public string Passport { get; set; }
        public string Direction { get; set; }
        public Gender Gender { get; set; }
        public int? PhotoId { get; set; }
        public virtual DocumentDto Photo { get; set; }
        public string PhotoFileName { get; set; }
    }
}
