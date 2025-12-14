namespace ProyectoFinalTecWeb.Entities
{
    public class Trip
    {
        public Guid Id { get; set; }
        public string Origin { get; set; }
        public string Destiny { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // 1:M Passenger -> Trip
        public Guid PassengerId { get; set; }
        public Passenger Passenger { get; set; } = default!;
        // 1:M Driver -> Trip

        public Guid DriverId { get; set; }
        public Driver Driver { get; set; } = default!;
    }
}
