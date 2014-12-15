using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arquitetura.Business.Interfaces;

namespace Arquitetura.Business.BusinessObjects
{
    public partial class shipper : IValidator
    {
        #region Primitive Properties
        public virtual Int32 ShipperID { get; set; }

        public virtual String CompanyName { get; set; }

        public virtual String Phone { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<order> _orders;
        public virtual ICollection<order> orders
        {
            get
            {
                if (_orders == null)
                    _orders = new List<order>();
                return _orders;
            }
            set { _orders = value; }
        }

        #endregion

        #region Public Methods (IValidator)
        public void Validate()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
