using ExamenAWSPelisSQLMauricio.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAWSPelisSQLMauricio.Data
{
    public class TelevisionContext : DbContext
    {
        public TelevisionContext(DbContextOptions<TelevisionContext> options) : base(options)
        {
        }
        public DbSet<Pelicula> Peliculas { get; set; }
    }
}
