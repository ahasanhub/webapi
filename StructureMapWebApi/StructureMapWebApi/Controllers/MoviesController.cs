using System.Web.Http;
using StructureMapWebApi.Lib.Interfaces;
using StructureMapWebApi.Lib.Repositories;

namespace StructureMapWebApi.Controllers
{
    [RoutePrefix("movies")]
    public class MoviesController : ApiController

    {
        private IMovieRepository _movieRepo;

        public MoviesController()
        {
            //_movieRepo = movieRepo;
            _movieRepo=new MovieRepository();
        }

        [HttpGet]
        [Route("all")]
        public IHttpActionResult All()
        {
            return Ok(_movieRepo.GetAllMovies());
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetByID(int id)
        {
            var movie = _movieRepo.GetByID(id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }
    }
}
