using ExamenAWSPelisSQLMauricio.Data;
using ExamenAWSPelisSQLMauricio.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAWSPelisSQLMauricio.Repositories
{
    public class RepositoryPeliculas
    {
        private TelevisionContext context;

        public RepositoryPeliculas(TelevisionContext context)
        {
            this.context = context;
        }

        public async Task<List<Pelicula>> GetPeliculasAsync()
        {
            return await this.context.Peliculas.ToListAsync();
        }

        public async Task<List<Pelicula>> GetPeliculasActorAsync(string actor)
        {
            return await this.context.Peliculas.Where(x=>x.Actores.Contains(actor)).ToListAsync();
        }
    }
}
