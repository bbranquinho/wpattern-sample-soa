using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arquitetura.Business.Interfaces;

namespace Arquitetura.Business.BusinessObjects
{
    public partial class region : IValidator
    {
        #region Primitive Properties
        public virtual Int32 RegionID { get; set; }

        public virtual String RegionDescription { get; set; }

        #endregion

        #region Navigation Properties
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
