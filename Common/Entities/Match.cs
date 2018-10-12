using System.Collections.Generic;

namespace Common.Entities
{
    public class Match : BaseEntity
    {
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
        public List<int> GoalScorers { get; set; }
    }
}
