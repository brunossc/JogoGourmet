using JogoGourmet.Core.Entities;
using JogoGourmet.Core.Repositories;
using JogoGourmet.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JogoGourmet.Infra.Repositories
{
    public class PratoRepository : DataRepository<Prato>, IPratoRepository
    {
        public PratoRepository(MyDbContext context)
     : base(context)
        {
        }
    }
}
