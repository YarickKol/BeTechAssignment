using AutoMapper;
using BusinessLogicLayer.ModelDTO;
using DataAccesLayer.Models;

namespace BusinessLogicLayer.Profiles
{
    public class CurrencyProfile:Profile
    {
        public CurrencyProfile()
        {
            CreateMap<Currency, CurrencyDTO>();
            CreateMap<CurrencyDTO, Currency>();
        }
    }
}
