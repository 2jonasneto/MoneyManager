using AutoMapper;
using MoneyManager.Domain.Entities;
using MoneyManager.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Application.AutoMapper
{
    public class ModelMapping : Profile
    {
        public ModelMapping()
        {
            CreateMap<AccountBank, AccountBankViewModel>()
                .ForMember(dest => dest.Transactions,
                           opt => opt.MapFrom(src => src.Transactions));

            CreateMap<AccountBankViewModel, AccountBank>();
            CreateMap<Transaction, TransactionViewModel>().ReverseMap();
            CreateMap<Bill, BillViewModel>().ReverseMap();
        }
    }
}
