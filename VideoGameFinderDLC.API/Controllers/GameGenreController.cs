using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoGameFinderDLC.Models;
using VideoGameFinderDLC.Services;

namespace VideoGameFinder.API.Controllers
{
    [Authorize]
    public class GameGenreController : ApiController
    {
        private GameGenreService service = new GameGenreService();

        // Get by ID
        public IHttpActionResult Get(int id)
        {
            var gameGenres = service.GetGameGenreById(id);
            return Ok(gameGenres);
        }

        // Get All Method
        public IHttpActionResult Get()
        {
            var gameGenres = service.GetGameGenres();
            return Ok(gameGenres);
        }

        // Post Method 
        public IHttpActionResult Post(GameGenreCreate gameGenre)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);



            if (!service.CreateGameGenre(gameGenre))
                return InternalServerError();

            return Ok();
        }

        // Put Method
        public IHttpActionResult Put(GameGenreEdit gameGenre)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!service.UpdateGameGenre(gameGenre))
                return InternalServerError();

            return Ok();
        }

        // Delete Method
        public IHttpActionResult Delete(int id)
        {

            if (!service.DeleteGameGenre(id))
                return InternalServerError();

            return Ok();
        }
    }

}
