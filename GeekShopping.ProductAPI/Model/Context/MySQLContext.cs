using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext: DbContext
    {                               
        public MySQLContext() {}

        //Construtor Padrão
        public MySQLContext(DbContextOptions<MySQLContext> options)  : base(options) 
        {}

        public DbSet <Product> Products { get; set; }
    }
}
