namespace Common.Entities
{
    public class Footballer : User
    {
        public int TeamId { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
    }
}
