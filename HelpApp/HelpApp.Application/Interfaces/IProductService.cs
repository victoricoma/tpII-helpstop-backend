﻿using HelpApp.Application.DTOs;

namespace HelpApp.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetById(int? id);

        //Task<ProductDTO> GetProductCategory(int? id);
        Task Add(ProductDTO productDto);
        Task Update(ProductDTO productDto);
        Task Remove(int? id);
    }
}
