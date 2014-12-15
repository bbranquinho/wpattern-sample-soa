using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arquitetura.Business.Interfaces;

namespace Arquitetura.Business.BusinessObjects
{
    public partial class customerdemographic : IValidator
    {
        #region Primitive Properties
        public virtual String CustomerTypeID { get; set; }

        public virtual String CustomerDesc { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<customer> _customers;
        public virtual ICollection<customer> customers
        {
            get
            {
                if (_customers == null)
                    _customers = new List<customer>();
                return _customers;
            }
            set { _customers = value; }
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
