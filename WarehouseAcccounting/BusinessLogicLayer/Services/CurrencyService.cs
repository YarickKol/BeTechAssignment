using AutoMapper;
using BusinessLogicLayer.ModelDTO;
using BusinessLogicLayer.Profiles;
using DataAccesLayer.Interfaces;
using DataAccesLayer.Models;
using System;

namespace BusinessLogicLayer.Services
{
    public class CurrencyService: IDisposable
    {
        private bool isDisposed = false;
        private IWarehouseUnitOfWork _unitOfWork;
        private IMapper mapper;
        private ExchangeRate _exchangeRate;

        public decimal Rate { get; set; }

        public CurrencyService(IWarehouseUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _exchangeRate = new ExchangeRate();
            mapper = AutoMapperProfileConfiguration.Configure().CreateMapper();
        } 

        public void UpdateCurrencyRate(string currencyCode)
        {
            Currency currency = _unitOfWork.Currencies.GetSingleItem(it => it.Code == currencyCode);            
            Rate = _exchangeRate.SetValues(currencyCode);
            try
            {
                currency.CurrencyRate = Rate;
                currency.UpdateDate = DateTime.Now;
                _unitOfWork.Currencies.UpdateItem(currency);
                _unitOfWork.Currencies.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Currency not found");
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
