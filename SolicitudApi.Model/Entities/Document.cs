using SolicitudApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Model.Entities
{
    public class Document : Base
    {
        public string FileName { get; set; } //file-store name
        public string OriginalName { get; set; } //selected file
        public string ContentType { get; set; }
    }
}
