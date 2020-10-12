using JogoGourmet.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JogoGourmet.Core.Entities
{
    public class Prato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Grupo Grupo { get; set; }
        public int GrupoId { get; set; }
        public string Nome { get; set; }
    }
}
