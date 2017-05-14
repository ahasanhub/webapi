using System.Collections.Generic;
using StructureMapWebApi.Lib.DataModels;

namespace StructureMapWebApi.Lib.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();

        Movie GetByID(int id);
    }
}
