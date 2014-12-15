using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Arquitetura.Service.DataTransferObject
{
    [DataContract(Name = "Employee")]
    public class employeeDto
    {
        #region Primitive Properties
        [DataMember]
        public Int32 EmployeeID { get; set; }

        [DataMember]
        public String LastName { get; set; }

        [DataMember]
        public String FirstName { get; set; }

        [DataMember]
        public String Title { get; set; }

        [DataMember]
        public String TitleOfCourtesy { get; set; }

        [DataMember]
        public Nullable<DateTime> BirthDate { get; set; }

        [DataMember]
        public Nullable<DateTime> HireDate { get; set; }

        [DataMember]
        public String Address { get; set; }

        [DataMember]
        public String City { get; set; }

        [DataMember]
        public String Region { get; set; }

        [DataMember]
        public String PostalCode { get; set; }

        [DataMember]
        public String Country { get; set; }

        [DataMember]
        public String HomePhone { get; set; }

        [DataMember]
        public String Extension { get; set; }

        [DataMember]
        public Byte[] Photo { get; set; }

        [DataMember]
        public String Notes { get; set; }

        [DataMember]
        public Nullable<Int32> ReportsTo { get; set; }

        [DataMember]
        public String PhotoPath { get; set; }

        [DataMember]
        public Nullable<Single> Salary { get; set; }
        #endregion

        #region Navigation Properties
        [DataMember]
        public IList<employeeDto> employees1;

        [DataMember]
        public IList<orderDto> orders;

        [DataMember]
        public IList<territoryDto> territories;
        #endregion
    }
}
