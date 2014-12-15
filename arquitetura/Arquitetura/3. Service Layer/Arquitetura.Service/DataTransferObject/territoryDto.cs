using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Arquitetura.Service.DataTransferObject
{
    [DataContract(Name = "Territory")]
    public class territoryDto
    {
        #region Primitive Properties
        [DataMember]
        public String TerritoryID { get; set; }

        [DataMember]
        public String TerritoryDescription { get; set; }

        [DataMember]
        public Int32 RegionID { get; set; }
        #endregion

        #region Navigation Properties
        [DataMember]
        public regionDto region { get; set; }

        [DataMember]
        public IList<employeeDto> employees;
        #endregion
    }
}
