using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Arquitetura.Service.DataTransferObject
{
    [DataContract(Name = "Product")]
    public class productDto
    {
        #region Primitive Properties
        [DataMember]
        public Int32 ProductID { get; set; }

        [DataMember]
        public String ProductName { get; set; }

        [DataMember]
        public Nullable<Int32> SupplierID { get; set; }

        [DataMember]
        public Nullable<Int32> CategoryID { get; set; }

        [DataMember]
        public String QuantityPerUnit { get; set; }

        [DataMember]
        public Nullable<Decimal> UnitPrice { get; set; }

        [DataMember]
        public Nullable<Int16> UnitsInStock { get; set; }

        [DataMember]
        public Nullable<Int16> UnitsOnOrder { get; set; }

        [DataMember]
        public Nullable<Int16> ReorderLevel { get; set; }

        [DataMember]
        public Boolean Discontinued { get; set; }
        #endregion

        #region Navigation Properties
        [DataMember]
        public categoryDto category { get; set; }

        [DataMember]
        public IList<order_detailDto> order_details;

        [DataMember]
        public supplierDto supplier { get; set; }
        #endregion
    }
}
