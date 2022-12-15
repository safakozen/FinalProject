﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDAL : IEntityRepository<Product>
    {
        //List<Product>GetAll();  
        //void Add(Product product);
        //void Update(Product product);
        //void Delete(Product product);

        //List<Product>GetAllByCategory(int categoryId);

        List<ProductDetailDto> GetProductDetails();
    }
}
