using AutoMapper;


namespace BusinessLogicLayer.Profiles
{
    public class AutoMapperProfileConfiguration
    {
        public static MapperConfiguration Configure()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new CurrencyProfile());
                cfg.AddProfile(new ProductCategoryProfile());
                cfg.AddProfile(new ProductProfile());
                cfg.AddProfile(new WarehouseProfile());
            });
        }
    }
}
