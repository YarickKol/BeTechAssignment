using AutoMapper;
using BusinessLogicLayer.ModelDTO;
using BusinessLogicLayer.Profiles;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Services
{
    public class SearchingService : IDisposable
    {
        private bool isDisposed = false;
        private IWarehouseUnitOfWork _unitOfWork;
        private IMapper mapper;

        public SearchingService(IWarehouseUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            mapper = AutoMapperProfileConfiguration.Configure().CreateMapper();
        }

        public IList<ProductDTO> GetProducts()
        {
            try
            {
                var products = mapper.Map<IEnumerable<Product>, IList<ProductDTO>>(
                     _unitOfWork.Products.GetAllItems());
                return products;                
            }
            catch (Exception)
            {
                throw new Exception("Products not found");   
            }
            
            
        }
        public void Dispose()
        {
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                _unitOfWork.Dispose();
                isDisposed = true;
            }
        }
    }
}
