namespace ProyectoFinalTecWeb.Entities
{
    public class Model
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public int year { get; set; }

        // 1:1 Vehicle->Model
        public Guid VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } = default!;
    }
}
