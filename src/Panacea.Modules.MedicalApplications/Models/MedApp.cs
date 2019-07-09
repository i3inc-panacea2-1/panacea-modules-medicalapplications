using Panacea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modules.MedicalApplications.Models
{
    [DataContract]
    public class MedApp : ServerItem
    {
        [DataMember(Name = "medapp_type")]
        public string MedAppType { get; set; }

        [DataMember(Name = "parameter")]
        public string Parameter { get; set; }

        [DataMember(Name = "parameter_thumbnail")]
        public Thumbnail ParameterThumbnail { get; set; }
    }
}
