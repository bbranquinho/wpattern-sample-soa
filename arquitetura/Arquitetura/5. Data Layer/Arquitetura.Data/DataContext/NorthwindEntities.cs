using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Linq;
using System.Text;
using Arquitetura.Business.BusinessObjects;
using Arquitetura.Data.DataContextInterfaces;

namespace Arquitetura.Data.DataContext
{
    public partial class NorthwindEntities : ObjectContext, INorthwindEntities
    {
        #region Constructors
        /// <summary>
        /// Initializes a new NorthwindEntities object using the connection string found in the 'NorthwindEntities' section of the application configuration file.
        /// </summary>
        public NorthwindEntities()
            : base("name=NorthwindEntities", "NorthwindEntities")
        {
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        public NorthwindEntities(string connectionString)
            : base(connectionString, "NorthwindEntities")
        {
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        public NorthwindEntities(EntityConnection connection)
            : base(connection, "NorthwindEntities")
        {
            OnContextCreated();
        }
        #endregion

        #region Partial Methods
        partial void OnContextCreated();
        #endregion

        #region ObjectSet Properties
        public ObjectSet<category> categories
        {
            get
            {
                if (_categories == null)
                    _categories = CreateObjectSet<category>("categories");
                return _categories;
            }
        }
        private ObjectSet<category> _categories;
        IObjectSet<category> INorthwindEntities.categories { get { return categories; } }

        public ObjectSet<customerdemographic> customerdemographics
        {
            get
            {
                if (_customerdemographics == null)
                    _customerdemographics = CreateObjectSet<customerdemographic>("customerdemographics");
                return _customerdemographics;
            }
        }
        private ObjectSet<customerdemographic> _customerdemographics;
        IObjectSet<customerdemographic> INorthwindEntities.customerdemographics { get { return customerdemographics; } }

        public ObjectSet<customer> customers
        {
            get
            {
                if (_customers == null)
                    _customers = CreateObjectSet<customer>("customers");
                return _customers;
            }
        }
        private ObjectSet<customer> _customers;
        IObjectSet<customer> INorthwindEntities.customers { get { return customers; } }

        public ObjectSet<employee> employees
        {
            get
            {
                if (_employees == null)
                    _employees = CreateObjectSet<employee>("employees");
                return _employees;
            }
        }
        private ObjectSet<employee> _employees;
        IObjectSet<employee> INorthwindEntities.employees { get { return employees; } }

        public ObjectSet<order_detail> order_details
        {
            get
            {
                if (_order_details == null)
                    _order_details = CreateObjectSet<order_detail>("order_details");
                return _order_details;
            }
        }
        private ObjectSet<order_detail> _order_details;
        IObjectSet<order_detail> INorthwindEntities.order_details { get { return order_details; } }

        public ObjectSet<order> orders
        {
            get
            {
                if (_orders == null)
                    _orders = CreateObjectSet<order>("orders");
                return _orders;
            }
        }
        private ObjectSet<order> _orders;
        IObjectSet<order> INorthwindEntities.orders { get { return orders; } }

        public ObjectSet<product> products
        {
            get
            {
                if (_products == null)
                    _products = CreateObjectSet<product>("products");
                return _products;
            }
        }
        private ObjectSet<product> _products;
        IObjectSet<product> INorthwindEntities.products { get { return products; } }

        public ObjectSet<region> regions
        {
            get
            {
                if (_regions == null)
                    _regions = CreateObjectSet<region>("regions");
                return _regions;
            }
        }
        private ObjectSet<region> _regions;
        IObjectSet<region> INorthwindEntities.regions { get { return regions; } }

        public ObjectSet<shipper> shippers
        {
            get
            {
                if (_shippers == null)
                    _shippers = CreateObjectSet<shipper>("shippers");
                return _shippers;
            }
        }
        private ObjectSet<shipper> _shippers;
        IObjectSet<shipper> INorthwindEntities.shippers { get { return shippers; } }

        public ObjectSet<supplier> suppliers
        {
            get
            {
                if (_suppliers == null)
                    _suppliers = CreateObjectSet<supplier>("suppliers");
                return _suppliers;
            }
        }
        private ObjectSet<supplier> _suppliers;
        IObjectSet<supplier> INorthwindEntities.suppliers { get { return suppliers; } }

        public ObjectSet<territory> territories
        {
            get
            {
                if (_territories == null)
                    _territories = CreateObjectSet<territory>("territories");
                return _territories;
            }
        }
        private ObjectSet<territory> _territories;
        IObjectSet<territory> INorthwindEntities.territories { get { return territories; } }

        #endregion

        #region AddTo Methods

        /// <summary>
        /// Deprecated Method for adding a new object to the categories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTocategories(category category)
        {
            base.AddObject("categories", category);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the customerdemographics EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTocustomerdemographics(customerdemographic customerdemographic)
        {
            base.AddObject("customerdemographics", customerdemographic);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the customers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTocustomers(customer customer)
        {
            base.AddObject("customers", customer);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the employees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToemployees(employee employee)
        {
            base.AddObject("employees", employee);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the order_details EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToorder_details(order_detail order_detail)
        {
            base.AddObject("order_details", order_detail);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToorders(order order)
        {
            base.AddObject("orders", order);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToproducts(product product)
        {
            base.AddObject("products", product);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the regions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToregions(region region)
        {
            base.AddObject("regions", region);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the shippers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToshippers(shipper shipper)
        {
            base.AddObject("shippers", shipper);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the suppliers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTosuppliers(supplier supplier)
        {
            base.AddObject("suppliers", supplier);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the territories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToterritories(territory territory)
        {
            base.AddObject("territories", territory);
        }
        #endregion

        #region CreateObject methods with initializer
        public category Createcategory(Int32? categoryID = null, String categoryName = null, String description = null, Byte[] picture = null)
        {
            category value = CreateObject<category>();
            if (categoryID != null)
                value.CategoryID = categoryID.Value;
            if (categoryName != null)
                value.CategoryName = categoryName;
            if (description != null)
                value.Description = description;
            if (picture != null)
                value.Picture = picture;
            return value;
        }

        public customerdemographic Createcustomerdemographic(String customerTypeID = null, String customerDesc = null)
        {
            customerdemographic value = CreateObject<customerdemographic>();
            if (customerTypeID != null)
                value.CustomerTypeID = customerTypeID;
            if (customerDesc != null)
                value.CustomerDesc = customerDesc;
            return value;
        }

        public customer Createcustomer(String customerID = null, String companyName = null, String contactName = null, String contactTitle = null, String address = null, String city = null, String region = null, String postalCode = null, String country = null, String phone = null, String fax = null)
        {
            customer value = CreateObject<customer>();
            if (customerID != null)
                value.CustomerID = customerID;
            if (companyName != null)
                value.CompanyName = companyName;
            if (contactName != null)
                value.ContactName = contactName;
            if (contactTitle != null)
                value.ContactTitle = contactTitle;
            if (address != null)
                value.Address = address;
            if (city != null)
                value.City = city;
            if (region != null)
                value.Region = region;
            if (postalCode != null)
                value.PostalCode = postalCode;
            if (country != null)
                value.Country = country;
            if (phone != null)
                value.Phone = phone;
            if (fax != null)
                value.Fax = fax;
            return value;
        }

        public employee Createemployee(Int32? employeeID = null, String lastName = null, String firstName = null, String title = null, String titleOfCourtesy = null, Nullable<DateTime> birthDate = null, Nullable<DateTime> hireDate = null, String address = null, String city = null, String region = null, String postalCode = null, String country = null, String homePhone = null, String extension = null, Byte[] photo = null, String notes = null, Nullable<Int32> reportsTo = null, String photoPath = null, Nullable<Single> salary = null)
        {
            employee value = CreateObject<employee>();
            if (employeeID != null)
                value.EmployeeID = employeeID.Value;
            if (lastName != null)
                value.LastName = lastName;
            if (firstName != null)
                value.FirstName = firstName;
            if (title != null)
                value.Title = title;
            if (titleOfCourtesy != null)
                value.TitleOfCourtesy = titleOfCourtesy;
            if (birthDate != null)
                value.BirthDate = birthDate;
            if (hireDate != null)
                value.HireDate = hireDate;
            if (address != null)
                value.Address = address;
            if (city != null)
                value.City = city;
            if (region != null)
                value.Region = region;
            if (postalCode != null)
                value.PostalCode = postalCode;
            if (country != null)
                value.Country = country;
            if (homePhone != null)
                value.HomePhone = homePhone;
            if (extension != null)
                value.Extension = extension;
            if (photo != null)
                value.Photo = photo;
            if (notes != null)
                value.Notes = notes;
            if (reportsTo != null)
                value.ReportsTo = reportsTo;
            if (photoPath != null)
                value.PhotoPath = photoPath;
            if (salary != null)
                value.Salary = salary;
            return value;
        }

        public order_detail Createorder_detail(Int32? orderID = null, Int32? productID = null, Decimal? unitPrice = null, Int16? quantity = null, Double? discount = null)
        {
            order_detail value = CreateObject<order_detail>();
            if (orderID != null)
                value.OrderID = orderID.Value;
            if (productID != null)
                value.ProductID = productID.Value;
            if (unitPrice != null)
                value.UnitPrice = unitPrice.Value;
            if (quantity != null)
                value.Quantity = quantity.Value;
            if (discount != null)
                value.Discount = discount.Value;
            return value;
        }

        public order Createorder(Int32? orderID = null, String customerID = null, Nullable<Int32> employeeID = null, Nullable<DateTime> orderDate = null, Nullable<DateTime> requiredDate = null, Nullable<DateTime> shippedDate = null, Nullable<Int32> shipVia = null, Nullable<Decimal> freight = null, String shipName = null, String shipAddress = null, String shipCity = null, String shipRegion = null, String shipPostalCode = null, String shipCountry = null)
        {
            order value = CreateObject<order>();
            if (orderID != null)
                value.OrderID = orderID.Value;
            if (customerID != null)
                value.CustomerID = customerID;
            if (employeeID != null)
                value.EmployeeID = employeeID;
            if (orderDate != null)
                value.OrderDate = orderDate;
            if (requiredDate != null)
                value.RequiredDate = requiredDate;
            if (shippedDate != null)
                value.ShippedDate = shippedDate;
            if (shipVia != null)
                value.ShipVia = shipVia;
            if (freight != null)
                value.Freight = freight;
            if (shipName != null)
                value.ShipName = shipName;
            if (shipAddress != null)
                value.ShipAddress = shipAddress;
            if (shipCity != null)
                value.ShipCity = shipCity;
            if (shipRegion != null)
                value.ShipRegion = shipRegion;
            if (shipPostalCode != null)
                value.ShipPostalCode = shipPostalCode;
            if (shipCountry != null)
                value.ShipCountry = shipCountry;
            return value;
        }

        public product Createproduct(Int32? productID = null, String productName = null, Nullable<Int32> supplierID = null, Nullable<Int32> categoryID = null, String quantityPerUnit = null, Nullable<Decimal> unitPrice = null, Nullable<Int16> unitsInStock = null, Nullable<Int16> unitsOnOrder = null, Nullable<Int16> reorderLevel = null, Boolean? discontinued = null)
        {
            product value = CreateObject<product>();
            if (productID != null)
                value.ProductID = productID.Value;
            if (productName != null)
                value.ProductName = productName;
            if (supplierID != null)
                value.SupplierID = supplierID;
            if (categoryID != null)
                value.CategoryID = categoryID;
            if (quantityPerUnit != null)
                value.QuantityPerUnit = quantityPerUnit;
            if (unitPrice != null)
                value.UnitPrice = unitPrice;
            if (unitsInStock != null)
                value.UnitsInStock = unitsInStock;
            if (unitsOnOrder != null)
                value.UnitsOnOrder = unitsOnOrder;
            if (reorderLevel != null)
                value.ReorderLevel = reorderLevel;
            if (discontinued != null)
                value.Discontinued = discontinued.Value;
            return value;
        }

        public region Createregion(Int32? regionID = null, String regionDescription = null)
        {
            region value = CreateObject<region>();
            if (regionID != null)
                value.RegionID = regionID.Value;
            if (regionDescription != null)
                value.RegionDescription = regionDescription;
            return value;
        }

        public shipper Createshipper(Int32? shipperID = null, String companyName = null, String phone = null)
        {
            shipper value = CreateObject<shipper>();
            if (shipperID != null)
                value.ShipperID = shipperID.Value;
            if (companyName != null)
                value.CompanyName = companyName;
            if (phone != null)
                value.Phone = phone;
            return value;
        }

        public supplier Createsupplier(Int32? supplierID = null, String companyName = null, String contactName = null, String contactTitle = null, String address = null, String city = null, String region = null, String postalCode = null, String country = null, String phone = null, String fax = null, String homePage = null)
        {
            supplier value = CreateObject<supplier>();
            if (supplierID != null)
                value.SupplierID = supplierID.Value;
            if (companyName != null)
                value.CompanyName = companyName;
            if (contactName != null)
                value.ContactName = contactName;
            if (contactTitle != null)
                value.ContactTitle = contactTitle;
            if (address != null)
                value.Address = address;
            if (city != null)
                value.City = city;
            if (region != null)
                value.Region = region;
            if (postalCode != null)
                value.PostalCode = postalCode;
            if (country != null)
                value.Country = country;
            if (phone != null)
                value.Phone = phone;
            if (fax != null)
                value.Fax = fax;
            if (homePage != null)
                value.HomePage = homePage;
            return value;
        }

        public territory Createterritory(String territoryID = null, String territoryDescription = null, Int32? regionID = null)
        {
            territory value = CreateObject<territory>();
            if (territoryID != null)
                value.TerritoryID = territoryID;
            if (territoryDescription != null)
                value.TerritoryDescription = territoryDescription;
            if (regionID != null)
                value.RegionID = regionID.Value;
            return value;
        }

        #endregion
    }
}
