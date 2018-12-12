using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ActividadComplementaria.Models
{
    public class Estado
    {
        [Key]
        public int id_estado { get; set; }
        public String nombre_estado { get; set; }
    }
}
