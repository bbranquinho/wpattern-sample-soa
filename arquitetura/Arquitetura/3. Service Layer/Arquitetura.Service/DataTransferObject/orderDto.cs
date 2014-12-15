using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Arquitetura.Service.DataTransferObject
{
    [DataContract(Name = "Order")]
    public class orderDto
    {
        #region Primitive Properties
        [DataMember]
        public Int32 OrderID { get; set; }

        [DataMember]
        public String CustomerID { get; set; }

        [DataMember]
        public Nullable<Int32> EmployeeID { get; set; }

        [DataMember]
        public Nullable<DateTime> OrderDate { get; set; }

        [DataMember]
        public Nullable<DateTime> RequiredDate { get; set; }

        [DataMember]
        public Nullable<DateTime> ShippedDate { get; set; }

        [DataMember]
        public Nullable<Int32> ShipVia { get; set; }

        [DataMember]
        public Nullable<Decimal> Freight { get; set; }

        [DataMember]
        public String ShipName { get; set; }

        [DataMember]
        public String ShipAddress { get; set; }

        [DataMember]
        public String ShipCity { get; set; }

        [DataMember]
        public String ShipRegion { get; set; }

        [DataMember]
        public String ShipPostalCode { get; set; }

        [DataMember]
        public String ShipCountry { get; set; }
        #endregion

        #region Navigation Properties
        [DataMember]
        public customerDto customer { get; set; }

        [DataMember]
        public employeeDto employee { get; set; }

        [DataMember]
        public IList<order_detailDto> _order_details;

        [DataMember]
        public shipperDto shipper { get; set; }
        #endregion
    }
}
