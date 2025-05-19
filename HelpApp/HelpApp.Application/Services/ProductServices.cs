using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Application.Interfaces;
using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;

namespace HelpApp.Application.Services
{
    public class ProductServices : IProductService
    {
        public Task Add(ProductDTO productDto)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDTO>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task Remove(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProductDTO productDto)
        {
            throw new NotImplementedException();
        }
    }
}
