using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Arquitetura.Business.Exceptions
{
    public class ValidationException : Exception
    {
        #region Constructors
        public ValidationException()
            : base()
        {
        }

        public ValidationException(String message)
            : base(message)
        {
        }

        public ValidationException(String message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ValidationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endregion
    }
}
