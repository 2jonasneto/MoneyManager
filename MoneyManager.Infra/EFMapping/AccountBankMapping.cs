using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoneyManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManager.Infra.EFMapping
{
    public sealed class AccountBankMapping : IEntityTypeConfiguration<AccountBank>
    {
        public void Configure(EntityTypeBuilder<AccountBank> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Transactions).WithOne(t => t.AccountBank).HasForeignKey(f => f.AccountBankId);
        }
    }

    public sealed class BillMapping : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}
