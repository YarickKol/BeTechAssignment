using AutoMapper;
using BusinessLogicLayer.ModelDTO;
using DataAccesLayer.Models;

namespace BusinessLogicLayer.Profiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
        }
    }
}
