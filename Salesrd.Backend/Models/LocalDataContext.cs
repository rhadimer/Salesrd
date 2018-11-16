namespace Salesrd.Backend.Models
{
    using Salesrd.Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Salesrd.Common.Models.Products> Products { get; set; }
    }
}