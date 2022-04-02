using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acesso_Branco.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Acesso_Branco
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt):
            base(opt)
        { }

        public DbSet <Usuario> USUARIOS { get; set; }
    }
}
