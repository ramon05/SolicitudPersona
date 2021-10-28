using SolicitudApi.Core.BaseModel;
using SolicitudApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Model.Entities
{
    public class Person : Base
    {
        public Person()
        {
            Teams = new HashSet<Team>();
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Bob { get; set; }
        public string Passport { get; set; }
        public string Direction { get; set; }
        public Gender Gender { get; set; }
        public int? PhotoId { get; set; }
        public virtual Document Photo { get; set; }
        public int SolicitudeId { get; set; }
        public Solicitude Solicitude { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }

}
