﻿using AdminPanelGetWay.Domain.Aggregates.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminPanelGetWay.Domain.Aggregates.RoleAggregate.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            //builder.Property(x => x.RoleName).HasConversion(x => x.RoleNameFa , c => new RoleName(c));
            builder.OwnsOne<RoleName>(x => x.RoleName);
        }
    }
}
