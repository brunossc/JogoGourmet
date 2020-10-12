using JogoGourmet.Core.Entities;
using System.Collections.Generic;

namespace JogoGourmet.Core
{
    public interface IGourmetService
    {
        Grupo ObterGrupo(int id);
        string ObterPrato(int id, int idGrupo);
        void SalvarGrupo(Grupo g);
        bool GrupoExiste(string nome);
        IEnumerable<Grupo> ObterGrupos();
        void SalvarPrato(Prato p);
        bool PratoExiste(string nome);
    }
}