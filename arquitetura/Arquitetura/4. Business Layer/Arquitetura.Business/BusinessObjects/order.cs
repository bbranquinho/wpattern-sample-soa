using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arquitetura.Business.Interfaces;

namespace Arquitetura.Business.BusinessObjects
{
    public partial class order : IValidator
    {
        #region Primitive Properties
        public virtual Int32 OrderID { get; set; }

        public virtual String CustomerID { get; set; }

        public virtual Nullable<Int32> EmployeeID { get; set; }

        public virtual Nullable<DateTime> OrderDate { get; set; }

        public virtual Nullable<DateTime> RequiredDate { get; set; }

        public virtual Nullable<DateTime> ShippedDate { get; set; }

        public virtual Nullable<Int32> ShipVia { get; set; }

        public virtual Nullable<Decimal> Freight { get; set; }

        public virtual String ShipName { get; set; }

        public virtual String ShipAddress { get; set; }

        public virtual String ShipCity { get; set; }

        public virtual String ShipRegion { get; set; }

        public virtual String ShipPostalCode { get; set; }

        public virtual String ShipCountry { get; set; }

        #endregion

        #region Navigation Properties
        public virtual customer customer { get; set; }

        public virtual employee employee { get; set; }

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

        public virtual shipper shipper { get; set; }

        #endregion

        #region Public Methods (IValidator)
        public void Validate()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
