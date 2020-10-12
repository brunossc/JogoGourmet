using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JogoGourmet.Core.Entities
{
    public class Grupo
    {
        public Grupo()
        {
            Pratos = new List<Prato>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual IList<Prato> Pratos { get; }

        public void AdicionarPrato(Prato p)
        {
            this.Pratos.Add(p);
        }
    }
}
