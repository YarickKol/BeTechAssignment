using AutoMapper;
using BusinessLogicLayer.ModelDTO;
using DataAccesLayer.Models;

namespace BusinessLogicLayer.Profiles
{
    public class WarehouseProfile:Profile
    {
        public WarehouseProfile()
        {
            CreateMap<Warehouse, WarehouseDTO>();
            CreateMap<WarehouseDTO, Warehouse>();
        }
    }
}
