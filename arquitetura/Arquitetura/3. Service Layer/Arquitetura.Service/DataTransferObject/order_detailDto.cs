using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Arquitetura.Service.DataTransferObject
{
    [DataContract(Name = "OrderDetail")]
    public class order_detailDto
    {
        #region Primitive Properties
        [DataMember]
        public Int32 OrderID { get; set; }

        [DataMember]
        public Int32 ProductID { get; set; }

        [DataMember]
        public Decimal UnitPrice { get; set; }

        [DataMember]
        public Int16 Quantity { get; set; }

        [DataMember]
        public Double Discount { get; set; }
        #endregion

        #region Navigation Properties
        [DataMember]
        public orderDto order { get; set; }

        [DataMember]
        public productDto product { get; set; }
        #endregion
    }
}
