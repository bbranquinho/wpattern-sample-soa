using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Arquitetura.Business.BusinessObjects;
using Arquitetura.Business.Exceptions;
using Arquitetura.Data.DataContext;
using Arquitetura.Data.Repository;
using Arquitetura.Data.RepositoryInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arquitetura.Test
{
    [TestClass]
    public class DatabaseTest
    {
        [TestMethod]
        public void TestNorthwindentitiesContext()
        {
            NorthwindEntities northwindEntities = new NorthwindEntities();

            foreach (category cat in northwindEntities.categories)
            {
                System.Diagnostics.Debug.WriteLine(String.Format("Category: CategoryID {0}", cat.CategoryID));
            }
        }

        [TestMethod]
        public void TestCategoryRepository()
        {
            ICategoryRepository categoryRepository = new CategoryRepository();

            foreach (var cat in categoryRepository.GetAll())
            {
                System.Diagnostics.Debug.WriteLine(String.Format("Category: CategoryID {0}", cat.CategoryID));
            }
        }

        [TestMethod]
        public void TestAddCategory_Failure()
        {
            ICategoryRepository categoryRepository = new CategoryRepository();

            category cat = new category()
                               {
                                   Description = "Description Failure"
                               };

            try
            {
                categoryRepository.Add(cat);

                categoryRepository.SaveChanges();
            }
            catch (ValidationException e)
            {
                return;
            }
            
            Assert.Fail("Invalid category.");
        }

        [TestMethod]
        public void TestAddCategory_Success()
        {
            ICategoryRepository categoryRepository = new CategoryRepository();

            category cat = new category()
                                {
                                    CategoryName = "Name Success",
                                    Description = "Description Success"
                                };

            try
            {
                categoryRepository.Add(cat);

                categoryRepository.SaveChanges();
            }
            catch (ValidationException e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
