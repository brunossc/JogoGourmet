using JogoGourmet.Core.Entities;
using JogoGourmet.Core.Repositories;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Forms;

namespace JogoGourmet.Core
{
    public class GourmetService : IGourmetService
    {
        private readonly IGrupoRepository _grupoRepo;
        private readonly IPratoRepository _pratoRepo;

        public GourmetService(IGrupoRepository grupoRepo, IPratoRepository pratoRepo)
        {
            _grupoRepo = grupoRepo;
            _pratoRepo = pratoRepo;
        }

        public Grupo ObterGrupo(int id) => _grupoRepo.Single(g => g.Id == id);

        public IEnumerable<Grupo> ObterGrupos() => _grupoRepo.GetAll();

        public string ObterPrato(int id, int idGrupo)
        {
            var prato = _grupoRepo.Single(g => g.Id == idGrupo).Pratos.ElementAtOrDefault(id);

            if (prato != null)
            {
                return prato.Nome;
            }

            return string.Empty;
        }

        public void SalvarGrupo(Grupo g)
        {
            _grupoRepo.Add(g);
            _grupoRepo.SaveChanges();
        }

        public bool GrupoExiste(string nome)
        {
            return _grupoRepo.Exists(g => g.Nome.ToLower() == nome.ToLower());
        }

        public void SalvarPrato(Prato p)
        {
            _pratoRepo.Add(p);
            _pratoRepo.SaveChanges();
        }

        public bool PratoExiste(string nome)
        {
            return _pratoRepo.Exists(g => g.Nome.ToLower() == nome.ToLower());
        }
    }
}
