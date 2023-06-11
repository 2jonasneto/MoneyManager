using AutoMapper;
using MoneyManager.Application.Interfaces;
using MoneyManager.Application.ViewModels;
using MoneyManager.Domain.Entities;
using MoneyManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Application.Services
{
    public class AccountBankService: IAccountBankService
    {
        private readonly IAccountBankRepository _bankRepository;
        private readonly IMapper _mapper;
        public AccountBankService(IAccountBankRepository bankRepository, IMapper mapper)
        {
            _bankRepository = bankRepository;
            _mapper = mapper;
        }

        public async Task AddAccountBank(AccountBankViewModel account)
        {

            await _bankRepository.Add( _mapper.Map<AccountBank>(account));
        }
        public async Task UpdateAccountBank(AccountBankViewModel account)
        {
            await _bankRepository.Update(_mapper.Map<AccountBank>(account));
        } 
        public async Task ChangeBalance(Guid id, decimal value)
        {
            var account= await _bankRepository.GetById(id);
            account.ChangeBalance(value);
            await _bankRepository.Update(account);
        }

        public async Task<IEnumerable<AccountBankViewModel>> GetAll()
        {
            var d= await _bankRepository.GetAll();
            return _mapper.Map<IEnumerable<AccountBankViewModel>>(d);
        }

    }
}
