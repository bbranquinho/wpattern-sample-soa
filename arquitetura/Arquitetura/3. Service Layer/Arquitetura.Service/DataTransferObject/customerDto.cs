using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Arquitetura.Service.DataTransferObject
{
    [DataContract(Name = "Customer")]
    public class customerDto
    {
        #region Primitive Properties
        [DataMember]
        public String CustomerID { get; set; }

        [DataMember]
        public String CompanyName { get; set; }

        [DataMember]
        public String ContactName { get; set; }

        [DataMember]
        public String ContactTitle { get; set; }

        [DataMember]
        public String Address { get; set; }

        [DataMember]
        public String City { get; set; }

        [DataMember]
        public String Region { get; set; }

        [DataMember]
        public String PostalCode { get; set; }

        [DataMember]
        public String Country { get; set; }

        [DataMember]
        public String Phone { get; set; }

        [DataMember]
        public String Fax { get; set; }
        #endregion

        #region Navigation Properties
        [DataMember]
        public IList<orderDto> orders;

        [DataMember]
        public IList<customerdemographicDto> customerdemographics;
        #endregion
    }
}
