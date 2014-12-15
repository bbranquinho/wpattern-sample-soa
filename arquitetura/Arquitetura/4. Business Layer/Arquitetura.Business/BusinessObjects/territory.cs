using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arquitetura.Business.Interfaces;

namespace Arquitetura.Business.BusinessObjects
{
    public partial class territory : IValidator
    {
        #region Primitive Properties
        public virtual String TerritoryID { get; set; }

        public virtual String TerritoryDescription { get; set; }

        public virtual Int32 RegionID { get; set; }

        #endregion

        #region Navigation Properties
        public virtual region region { get; set; }

        private ICollection<employee> _employees;
        public virtual ICollection<employee> employees
        {
            get
            {
                if (_employees == null)
                    _employees = new List<employee>();
                return _employees;
            }
            set { _employees = value; }
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
