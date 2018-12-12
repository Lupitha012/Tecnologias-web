using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ActividadComplementaria.Models
{
    public class Municipio
    {
        [Key]
        public int id_municipio { get; set; }
        public String nombre_municipio { get; set; }
        public int municipio_id_municipio { get; set; }
    }
}
