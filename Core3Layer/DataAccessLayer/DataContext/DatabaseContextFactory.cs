﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.DataContext
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        DatabaseContext IDesignTimeDbContextFactory<DatabaseContext>.CreateDbContext(string[] args)
        {
            AppConfiguration appConfig = new AppConfiguration();
            var opsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            opsBuilder.UseSqlServer(appConfig.sqlConnectionString);
            return new DatabaseContext(opsBuilder.Options);
        }
    }
}
