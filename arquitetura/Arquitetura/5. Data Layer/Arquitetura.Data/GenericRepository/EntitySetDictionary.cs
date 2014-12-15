using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arquitetura.Data.GenericRepository
{
    public static class EntitySetDictionary
    {
        private static Dictionary<string, string> EntitySetKey = new Dictionary<string, string>
                                                                     {
                                                                         { "category", "categories"},
                                                                         { "customerdemographic", "customerdemographics" },
                                                                         { "customer", "customers" },
                                                                         { "employee", "employees" },
                                                                         { "order_detail", "order_details" },
                                                                         { "order", "orders" },
                                                                         { "product", "products" },
                                                                         { "region", "regions" },
                                                                         { "shipper", "shippers" },
                                                                         { "supplier", "suppliers" },
                                                                         { "territory", "territories" }
                                                                        
                                                                     };

        public static string GetEntityKey(string key)
        {
            string result;
            return EntitySetKey.TryGetValue(key, out result) ? result : null;
        }

        public static string GetEntityKey(object entity)
        {
            string result;
            return EntitySetKey.TryGetValue(entity.GetType().Name, out result) ? result : null;
        }
    }
}
