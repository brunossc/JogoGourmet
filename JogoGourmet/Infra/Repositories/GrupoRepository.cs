using JogoGourmet.Core.Entities;
using JogoGourmet.Core.Repositories;
using JogoGourmet.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JogoGourmet.Infra.Repositories
{
    public class GrupoRepository : DataRepository<Grupo>, IGrupoRepository
    {
        public GrupoRepository(MyDbContext context)
     : base(context)
        {
        }
    }
}
