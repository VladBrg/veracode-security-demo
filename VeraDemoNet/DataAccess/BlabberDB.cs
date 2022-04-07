using System.Configuration;
using System.Data.Entity;

namespace VeraDemoNet.DataAccess
{
    public class BlabberDB : DbContext  
    {
        //const string DATA_SOURCE = "(localdb)\\MSSQLLocalDB";
        //const string DB_FILENAME = "|DataDirectory|VeraDemoNet.mdf";
        //const string LOGIN = "admin";
        //const string PASSWORD = "admin123";
        //const string OPTIONS = "Integrated Security=True;User Instance=False";
        static readonly string connDb = ConfigurationManager.ConnectionStrings["VeraDemoNet"].ConnectionString;

        //public BlabberDB() : base($"Data Source={DATA_SOURCE};AttachDbFilename={DB_FILENAME};User Id={LOGIN};Password={PASSWORD};{OPTIONS}")
        public BlabberDB() : base(nameOrConnectionString: connDb)
        {  
        }  
  
        protected override void OnModelCreating(DbModelBuilder modelBuilder)  
        {  
            modelBuilder.Entity<User>().HasKey(x=>x.UserName);
        }


  
        public DbSet<User> Users { get; set; }  
    }  
}