using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ActividadComplementaria.Models
{
    public class Localidades
    {
        [Key]
        public int id_localidades { get; set; }
        public String localidad { get; set; }
        public int municipio_id_municipio { get; set; }
    }
}
