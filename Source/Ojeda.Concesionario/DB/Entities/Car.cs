using System.ComponentModel;

namespace Ojeda.Concesionario.DB.Entities
{
    public class Car
    {
        public int Id { get; set; }

        [DisplayName("Código")]
        public string Code { get; set; }

        [DisplayName("Marca")]
        public string Brand { get; set; }

        [DisplayName("Modelo")]
        public string Model { get; set; }

        [DisplayName("Kilómetros")]
        public int Kilometers { get; set; }

        [DisplayName("Precio")]
        public decimal Price { get; set; }

        [DisplayName("Tipo")]
        public string Type { get; set; }

        [DisplayName("Año")]
        public int Year { get; set; }

        [DisplayName("Descripcion")]
        public string Description { get; set; }

        [DisplayName("Patente")]
        public string Patent { get; set; }

        [DisplayName("Foto")]
        public byte[] Photo { get; set; }

        public bool Active { get; set; }

        public DateTime IncomeDate { get; set; }

        public Car()
        {

        }
    }
}
