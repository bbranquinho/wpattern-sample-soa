using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Arquitetura.Service.DataTransferObject;

namespace Arquitetura.Service.ServiceContract
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        IList<categoryDto> GetAllCategories();

        [OperationContract]
        categoryDto FindCategoryById(Int32 id);

        [OperationContract]
        void DeleteCategory(categoryDto category);

        [OperationContract]
        void UpdateCategory(categoryDto category);

        [OperationContract]
        void AddCategory(categoryDto category);
    }
}
