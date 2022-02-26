using Crud_Pattern_Repository.Interfaces;
using Crud_Pattern_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Pattern_Repository.Services
{
    public class ProductService : BaseService<Product>
    {
        public ProductService(IBaseRepository<Product> repository) : base(repository)
        {
        }
    }
}
