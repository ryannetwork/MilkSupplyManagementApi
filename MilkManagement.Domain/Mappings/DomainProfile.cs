﻿using AutoMapper;
using MilkManagement.Domain.Dto;
using MilkManagement.Domain.Dto.RequestDto;
using MilkManagement.Domain.Dto.ResponseDto;
using MilkManagement.Domain.Entities.Customer;
using MilkManagement.Domain.Entities.Expense;
using MilkManagement.Domain.Entities.Market;
using MilkManagement.Domain.Entities.Supplier;

namespace MilkManagement.Domain.Mappings
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Customer, CustomerRequestDto>().ReverseMap();
            CreateMap<CustomerRates, CustomerRatesResponseDto>().ReverseMap();
            CreateMap<CustomerRates, CustomerRatesRequestDto>().ReverseMap();
            CreateMap<CustomerSupplied, CustomerSuppliedRequestDto>().ReverseMap();
            CreateMap<CustomerSupplied, CustomerSuppliedResponseDto>().ReverseMap();
            CreateMap<SupplierRate, SupplierRatesRequestDto>().ReverseMap();
            CreateMap<SupplierRate, GetSupplierRateResponseDto>().ReverseMap();
            CreateMap<SupplierSupplied, SupplierSuppliedRequestDto>().ReverseMap();
            CreateMap<SupplierSupplied, SupplierSuppliedResponseDto>().ReverseMap();
            CreateMap<DailyExpense, ExpenseRateRequestDto>().ReverseMap();
            CreateMap<DailyExpense, ExpenseRateResponseDto>().ReverseMap();
            CreateMap<MarketSupplier, MarketSupplierRequestDto>().ReverseMap();
            CreateMap<MarketSupplier, MarketSupplierResponseDto>().ReverseMap();
            CreateMap<MarketPurchase, MarketPurchaseRequestDto>().ReverseMap();
            CreateMap<MarketPurchaseResponseDto, MarketPurchaseResponseDto>().ReverseMap();
            CreateMap<MarketSell, MarketSellRequestDto>().ReverseMap();
            CreateMap<MarketSell, MarketSellResponseDto>().ReverseMap();




            CreateMap<Expense, ExpenseRequestDto>().ReverseMap();
            CreateMap<Customer, CustomerResponseDto>().ReverseMap();
            
            CreateMap<Customer, CustomerResponseDto>()
                .ForMember(x => x.Type, opt => { opt.MapFrom(o => o.CustomerType.Type); }).ReverseMap();
            CreateMap<CustomerRates, CustomerRatesResponseDto>()
                .ForMember(x => x.Type, opt => { opt.MapFrom(o => o.Customer.CustomerType.Type); }).ReverseMap();

            //CreateMap<Supplier, CustomerRatesRequestDto>().ReverseMap();
            //CreateMap<Supplier, CustomerRatesResponseDto>().ReverseMap();
        }
    }
}
