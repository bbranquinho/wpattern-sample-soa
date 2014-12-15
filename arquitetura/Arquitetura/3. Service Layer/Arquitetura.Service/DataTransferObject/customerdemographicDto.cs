using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Arquitetura.Service.DataTransferObject
{
    [DataContract(Name = "CustomerDemographic")]
    public class customerdemographicDto
    {
        #region Primitive Properties
        [DataMember]
        public String CustomerTypeID { get; set; }

        [DataMember]
        public String CustomerDesc { get; set; }
        #endregion

        #region Navigation Properties
        [DataMember]
        public IList<customerDto> customers;
        #endregion
    }
}
