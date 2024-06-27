

namespace BusITLAApp.Data.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartTime { get; set; }
        public int Administrador { get; set; }
    }
}
