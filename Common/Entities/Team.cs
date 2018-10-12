namespace Common.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
    }
}
