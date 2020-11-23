using AutoMapper;
using BusinessLogicLayer.ModelDTO;
using BusinessLogicLayer.Profiles;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using System;


namespace BusinessLogicLayer.Services
{
    public class ProductService: IDisposable
    {
        private bool isDisposed = false;
        private IWarehouseUnitOfWork _unitOfWork;
        private IMapper mapper;

        public ProductService(IWarehouseUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            mapper = AutoMapperProfileConfiguration.Configure().CreateMapper();
        }

        public void AddProduct(ProductDTO product)
        {
            var transProduct = mapper.Map<ProductDTO, Product>(product);
            _unitOfWork.Products.CreateItem(transProduct);
            _unitOfWork.Products.SaveChanges();
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
