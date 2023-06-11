using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoneyManager.Application.AutoMapper;
using MoneyManager.Application.Interfaces;
using MoneyManager.Application.Services;
using MoneyManager.Domain.Interfaces;
using MoneyManager.Infra.Base;
using MoneyManager.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Application.Base
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureMVC(this IServiceCollection services,IConfiguration configuration )
        {
            services.AddDbContext<AppDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(ModelMapping));

            services.AddScoped<IAccountBankRepository, AccountBankRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IBillRepository, BillRepository>();
            services.AddScoped<IUnitForWork, UnitForWork>();
            services.AddScoped<IAccountBankService, AccountBankService>();
            return services;
        }
    }
}
