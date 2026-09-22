using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Localidad
    {
        //[Browsable(false)]
        public int Id { get; set; } = 0;
        [DisplayName("Nombre de la localidad")]
        public string Name { get; set; }= string.Empty;
        //[Browsable(false)]
        public int ProvinciaId { get; set; } = 1;
        [DisplayName("Provincia")]
        public Provincia? Provincia { get; set; } = null;
        //[Browsable(false)]
        public int PaisId { get; set; } = 1;
        [DisplayName("Pais")]
        public Pais? Pais { get; set; } = null;
        [Browsable(false)]
        public bool IsDeleted { get; set; } = false;

        public override string ToString()
        {
            return Name;
        }
    }
}
