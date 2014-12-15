using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arquitetura.Business.BusinessObjects;
using Arquitetura.Data.Repository;
using Arquitetura.Data.RepositoryInterfaces;
using Arquitetura.Service.DataTransferObject;
using Arquitetura.Service.ServiceContract;
using AutoMapper;

namespace Arquitetura.Service.ServiceImplementation
{
    public class CategoryService : ICategoryService
    {
        #region Properties
        private static ICategoryRepository CategoryRepository { get; set; }
        #endregion

        #region Constructor
        static CategoryService()
        {
            Mapper.CreateMap<category, categoryDto>();
            Mapper.CreateMap<customerdemographic, customerdemographicDto>();
            Mapper.CreateMap<customer, customerDto>();
            Mapper.CreateMap<employee, employeeDto>();
            Mapper.CreateMap<order_detail, order_detailDto>();
            Mapper.CreateMap<order, orderDto>();
            Mapper.CreateMap<product, productDto>();
            Mapper.CreateMap<region, regionDto>();
            Mapper.CreateMap<shipper, shipperDto>();
            Mapper.CreateMap<supplier, supplierDto>();
            Mapper.CreateMap<territory, territoryDto>();

            Mapper.CreateMap<categoryDto, category>();
            Mapper.CreateMap<customerdemographicDto, customerdemographic>();
            Mapper.CreateMap<customerDto, customer>();
            Mapper.CreateMap<employeeDto, employee>();
            Mapper.CreateMap<order_detailDto, order_detail>();
            Mapper.CreateMap<orderDto, order>();
            Mapper.CreateMap<productDto, product>();
            Mapper.CreateMap<regionDto, region>();
            Mapper.CreateMap<shipperDto, shipper>();
            Mapper.CreateMap<supplierDto, supplier>();
            Mapper.CreateMap<territoryDto, territory>();

            CategoryRepository = new CategoryRepository();
        }
        #endregion

        #region Services
        public IList<categoryDto> GetAllCategories()
        {
            return Mapper.Map<IList<category>, IList<categoryDto>>(CategoryRepository.GetAll().ToList());
        }

        public categoryDto FindCategoryById(Int32 id)
        {
            category cat = CategoryRepository.First(c => c.CategoryID.Equals(id));

            return Mapper.Map<category, categoryDto>(cat);
        }

        public void DeleteCategory(categoryDto category)
        {
            CategoryRepository.Delete(Mapper.Map<categoryDto, category>(category));
        }

        public void UpdateCategory(categoryDto category)
        {
            CategoryRepository.Update(Mapper.Map<categoryDto, category>(category));
        }

        public void AddCategory(categoryDto category)
        {
            CategoryRepository.Add(Mapper.Map<categoryDto, category>(category));
        }
        #endregion
    }
}
