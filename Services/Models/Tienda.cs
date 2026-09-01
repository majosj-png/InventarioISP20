namespace Services.Models
{
    public class Tienda
    {
        public int? id { get; set; }
        public DateTime? created_at { get; set; }
        public string marca { get; set; }
        public float precio { get; set; }
        public string tipo_cliente { get; set; }
        public string tipo_articulo { get; set; }
        public string estacion { get; set; }
    }
}
