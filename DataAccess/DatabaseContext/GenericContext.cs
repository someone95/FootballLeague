using System.Data.Entity;

namespace DataAccess.DatabaseContext
{
    internal class GenericContext<T> : DbContext where T : class
    {
        internal DbSet<T> Items { get; set; }

        internal GenericContext()
            : base("FootballLeagueContext")
        {
            this.Items = base.Set<T>();
        }
    }
}
