using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arquitetura.Business.Interfaces;

namespace Arquitetura.Business.BusinessObjects
{
    public partial class customer : IValidator
    {
        #region Primitive Properties
        public virtual String CustomerID { get; set; }

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

        private ICollection<customerdemographic> _customerdemographics;
        public virtual ICollection<customerdemographic> customerdemographics
        {
            get
            {
                if (_customerdemographics == null)
                    _customerdemographics = new List<customerdemographic>();
                return _customerdemographics;
            }
            set { _customerdemographics = value; }
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
