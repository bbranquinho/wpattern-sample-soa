using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arquitetura.Business.Exceptions;
using Arquitetura.Business.Interfaces;
using Arquitetura.Validator;

namespace Arquitetura.Business.BusinessObjects
{
    public partial class category : IValidator
    {
        #region Primitive Properties
        public virtual Int32 CategoryID { get; set; }

        public virtual String CategoryName { get; set; }

        public virtual String Description { get; set; }

        public virtual Byte[] Picture { get; set; }
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
            if (!ValidateFields.ValidateRequerid(CategoryName))
            {
                throw new ValidationException("Field CategoryName is requerid.");
            }
        }
        #endregion
    }
}
