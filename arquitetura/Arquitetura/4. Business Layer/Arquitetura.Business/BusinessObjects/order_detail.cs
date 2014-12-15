using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arquitetura.Business.Interfaces;

namespace Arquitetura.Business.BusinessObjects
{
    public partial class order_detail : IValidator
    {
        #region Primitive Properties
        public virtual Int32 OrderID { get; set; }

        public virtual Int32 ProductID { get; set; }

        public virtual Decimal UnitPrice { get; set; }

        public virtual Int16 Quantity { get; set; }

        public virtual Double Discount { get; set; }

        #endregion

        #region Navigation Properties
        public virtual order order { get; set; }

        public virtual product product { get; set; }

        #endregion

        #region Public Methods (IValidator)
        public void Validate()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
