﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005配置一对多关系.EntityConfig
{
    public class ClassConfig : EntityTypeConfiguration<Class>
    {
        public ClassConfig()
        {
            ToTable("T_Classes");

            HasMany(e => e.Students).WithRequired().HasForeignKey(e => e.ClassId);
        }
    }
}