﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Demo.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Models
{
    public partial interface INorthwindContextProcedures
    {
        Task<List<SalesByCategoryResult>> SalesByCategoryAsync(string categoryName, string ordYear, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
