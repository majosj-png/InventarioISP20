using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Cliente
    {
        [Browsable(false)]
        public int Id { get; set; } = 0;
       
        [DisplayName("Fecha de creacion")]
        public DateTimeOffset? Created_at { get; set; } = DateTimeOffset.UtcNow;
       
        [DisplayName("Nombres")]
        public string Firstname { get; set; }   = string.Empty;
        
        [DisplayName("Apellido")]
        public string Lastname { get; set; }= string.Empty;

        public string Dni { get; set; }= string.Empty;
        
        [DisplayName("Direccion")]
        public string Address { get; set; }= string.Empty;
       
        [Browsable(false)]
        public int LocalidadId { get; set; } = 0;

        public Localidad? Localidad { get; set; }
        
        [Browsable(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
