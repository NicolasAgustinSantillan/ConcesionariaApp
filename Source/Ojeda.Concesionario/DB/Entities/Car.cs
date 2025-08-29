namespace Ojeda.Concesionario.DB.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string Patent { get; set; }
        public int Kilometers { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }
        public DateTime IncomeDate { get; set; }
    }
}
