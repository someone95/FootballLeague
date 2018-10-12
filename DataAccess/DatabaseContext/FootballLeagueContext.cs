using Common.Entities;
using System.Data.Entity;

namespace DataAccess.DatabaseContext
{
    public class FootballLeagueContext : DbContext
    {
        internal DbSet<Footballer> Footballers { get; set; }
        internal DbSet<Match> Matches { get; set; }
        internal DbSet<Team> Teams { get; set; }
        internal DbSet<Referee> Referees { get; set; }

        public FootballLeagueContext()
            : base("FootballLeagueContext")
        {

        }
    }
}
