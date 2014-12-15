using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Arquitetura.Service.DataTransferObject
{
    [DataContract(Name = "Region")]
    public class regionDto
    {
        #region Primitive Properties
        [DataMember]
        public Int32 RegionID { get; set; }

        [DataMember]
        public String RegionDescription { get; set; }
        #endregion

        #region Navigation Properties
        [DataMember]
        public IList<territoryDto> territories;
        #endregion
    }
}
