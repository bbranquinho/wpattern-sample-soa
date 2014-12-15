using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using Arquitetura.Business.BusinessObjects;

namespace Arquitetura.Data.DataContextInterfaces
{
    public interface INorthwindEntities
    {
        IObjectSet<category> categories { get; }
        IObjectSet<customerdemographic> customerdemographics { get; }
        IObjectSet<customer> customers { get; }
        IObjectSet<employee> employees { get; }
        IObjectSet<order_detail> order_details { get; }
        IObjectSet<order> orders { get; }
        IObjectSet<product> products { get; }
        IObjectSet<region> regions { get; }
        IObjectSet<shipper> shippers { get; }
        IObjectSet<supplier> suppliers { get; }
        IObjectSet<territory> territories { get; }
    }
}
