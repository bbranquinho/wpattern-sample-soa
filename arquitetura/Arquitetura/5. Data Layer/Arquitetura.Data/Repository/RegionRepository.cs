using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Arquitetura.Business.BusinessObjects;
using Arquitetura.Data.GenericRepository;
using Arquitetura.Data.RepositoryInterfaces;

namespace Arquitetura.Data.Repository
{
    public class RegionRepository : Repository<region>, IRegionRepository
    {
    }
}
