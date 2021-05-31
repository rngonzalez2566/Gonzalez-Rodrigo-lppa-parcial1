using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gonzalez_Rodrigo_lppa_parcial1.RG.Entities.Models
{
    public class Afiliados: IdentityBase
    {
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Apellido { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(25)]
        public string Cuit { get; set; }

        [Required]
        [MaxLength(50)]
        public string telefono { get; set; }



    }
}