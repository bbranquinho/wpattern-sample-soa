using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Arquitetura.Service.DataTransferObject
{
    [DataContract(Name = "Supplier")]
    public class supplierDto
    {
        #region Primitive Properties
        [DataMember]
        public Int32 SupplierID { get; set; }

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

        [DataMember]
        public String HomePage { get; set; }
        #endregion

        #region Navigation Properties
        [DataMember]
        public IList<productDto> products;
        #endregion
    }
}
