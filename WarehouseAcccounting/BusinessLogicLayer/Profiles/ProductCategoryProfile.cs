using AutoMapper;
using BusinessLogicLayer.ModelDTO;
using DataAccesLayer.Models;

namespace BusinessLogicLayer.Profiles
{
    public class ProductCategoryProfile:Profile
    {
        public ProductCategoryProfile()
        {
            CreateMap<ProductCategory, ProductCategoryDTO>();
            CreateMap<ProductCategoryDTO, ProductCategory>();
        }
    }
}
