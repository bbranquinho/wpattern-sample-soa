using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arquitetura.Business.Interfaces;

namespace Arquitetura.Business.BusinessObjects
{
    public partial class product : IValidator
    {
        #region Primitive Properties
        public virtual Int32 ProductID { get; set; }

        public virtual String ProductName { get; set; }

        public virtual Nullable<Int32> SupplierID { get; set; }

        public virtual Nullable<Int32> CategoryID { get; set; }

        public virtual String QuantityPerUnit { get; set; }

        public virtual Nullable<Decimal> UnitPrice { get; set; }

        public virtual Nullable<Int16> UnitsInStock { get; set; }

        public virtual Nullable<Int16> UnitsOnOrder { get; set; }

        public virtual Nullable<Int16> ReorderLevel { get; set; }

        public virtual Boolean Discontinued { get; set; }

        #endregion

        #region Navigation Properties
        public virtual category category { get; set; }

        private ICollection<order_detail> _order_details;
        public virtual ICollection<order_detail> order_details
        {
            get
            {
                if (_order_details == null)
                    _order_details = new List<order_detail>();
                return _order_details;
            }
            set { _order_details = value; }
        }

        public virtual supplier supplier { get; set; }

        #endregion

        #region Public Methods (IValidator)
        public void Validate()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
