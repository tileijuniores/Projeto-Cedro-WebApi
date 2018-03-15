using RestauranteWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestauranteWebAPP.DAL
{
    public class Context : DbContext
    {
        // construtor que faz a referencia pro banco, alem de ter e manipular os dados 
        public Context() : base("RestauranteConnectionStringName") { }

        // propriedades que vamos manipular, restaurante e prato
        public DbSet<Restaurantes> Restaurantes { get; set; }

        public DbSet<Pratos> Pratos { get; set; }
    }
}
