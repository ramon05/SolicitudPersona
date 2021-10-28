using SolicitudApi.Core.BaseModel;
using SolicitudApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Model.Entities
{
    public class Solicitude : Base
    {
        public Solicitude()
        {
            Persons = new HashSet<Person>();
        }
        public Status StatusName { get; set; }
        public string CreadDate { get; set; } 
        public virtual ICollection<Person> Persons { get; set; }
    }
}
