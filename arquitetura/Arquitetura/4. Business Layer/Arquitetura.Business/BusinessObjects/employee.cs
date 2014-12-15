using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arquitetura.Business.Interfaces;

namespace Arquitetura.Business.BusinessObjects
{
    public partial class employee : IValidator
    {
        #region Primitive Properties
        public virtual Int32 EmployeeID { get; set; }

        public virtual String LastName { get; set; }

        public virtual String FirstName { get; set; }

        public virtual String Title { get; set; }

        public virtual String TitleOfCourtesy { get; set; }

        public virtual Nullable<DateTime> BirthDate { get; set; }

        public virtual Nullable<DateTime> HireDate { get; set; }

        public virtual String Address { get; set; }

        public virtual String City { get; set; }

        public virtual String Region { get; set; }

        public virtual String PostalCode { get; set; }

        public virtual String Country { get; set; }

        public virtual String HomePhone { get; set; }

        public virtual String Extension { get; set; }

        public virtual Byte[] Photo { get; set; }

        public virtual String Notes { get; set; }

        public virtual Nullable<Int32> ReportsTo { get; set; }

        public virtual String PhotoPath { get; set; }

        public virtual Nullable<Single> Salary { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<employee> _employees1;
        public virtual ICollection<employee> employees1
        {
            get
            {
                if (_employees1 == null)
                    _employees1 = new List<employee>();
                return _employees1;
            }
            set { _employees1 = value; }
        }

        public virtual employee employee1 { get; set; }

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

        private ICollection<territory> _territories;
        public virtual ICollection<territory> territories
        {
            get
            {
                if (_territories == null)
                    _territories = new List<territory>();
                return _territories;
            }
            set { _territories = value; }
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
