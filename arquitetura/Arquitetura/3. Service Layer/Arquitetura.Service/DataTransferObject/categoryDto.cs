using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Arquitetura.Service.DataTransferObject
{
    [DataContract(Name = "Category")]
    public class categoryDto
    {
        #region Primitive Properties
        [DataMember]
        public Int32 CategoryID { get; set; }

        [DataMember]
        public String CategoryName { get; set; }

        [DataMember]
        public String Description { get; set; }

        //[DataMember]
        //public Byte[] Picture { get; set; }
        #endregion

        #region Navigation Properties
        [DataMember]
        public IList<productDto> products;
        #endregion
    }
}
