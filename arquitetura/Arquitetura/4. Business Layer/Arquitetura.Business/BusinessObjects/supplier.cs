using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arquitetura.Business.Interfaces;

namespace Arquitetura.Business.BusinessObjects
{
    public partial class supplier : IValidator
    {
        #region Primitive Properties
        public virtual Int32 SupplierID { get; set; }

        public virtual String CompanyName { get; set; }

        public virtual String ContactName { get; set; }

        public virtual String ContactTitle { get; set; }

        public virtual String Address { get; set; }

        public virtual String City { get; set; }

        public virtual String Region { get; set; }

        public virtual String PostalCode { get; set; }

        public virtual String Country { get; set; }

        public virtual String Phone { get; set; }

        public virtual String Fax { get; set; }

        public virtual String HomePage { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<product> _products;
        public virtual ICollection<product> products
        {
            get
            {
                if (_products == null)
                    _products = new List<product>();
                return _products;
            }
            set { _products = value; }
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
