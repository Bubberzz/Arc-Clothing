﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIDAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}
