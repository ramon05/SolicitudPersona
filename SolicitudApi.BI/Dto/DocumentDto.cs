using SolicitudApi.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.BI.Dto
{
    public class DocumentDto : BaseDto
    {
        public string FileName { get; set; } //file-store name
        public string OriginalName { get; set; } //selected file
        public string ContentType { get; set; }
    }
}
