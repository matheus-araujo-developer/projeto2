﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace Sistema_Cadastro.Data
{
    public class Sistema_CadastroContext : DbContext
    {
        public Sistema_CadastroContext (DbContextOptions<Sistema_CadastroContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
