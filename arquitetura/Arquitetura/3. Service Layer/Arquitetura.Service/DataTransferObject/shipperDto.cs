using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Arquitetura.Service.DataTransferObject
{
    [DataContract(Name = "Shipper")]
    public class shipperDto
    {
        #region Primitive Properties
        [DataMember]
        public Int32 ShipperID { get; set; }

        [DataMember]
        public String CompanyName { get; set; }

        [DataMember]
        public String Phone { get; set; }
        #endregion

        #region Navigation Properties
        [DataMember]
        public IList<orderDto> orders;
        #endregion
    }
}
