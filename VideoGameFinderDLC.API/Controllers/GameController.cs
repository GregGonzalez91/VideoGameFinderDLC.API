using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoGameFinderDLC.Models;
using VideoGameFinderDLC.Services;

namespace VideoGameFinderDLC.API.Controllers
{
    [Authorize] 
    public class GameController : ApiController
    {
        private GameService service = new GameService();

        public IHttpActionResult Get()
        {
           
            var game = service.GetGame();
            return Ok(game);
        }

        public IHttpActionResult Post(GameCreate game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            if (!service.CreateGame(game))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            var game = service.GetGameById(id);
            return Ok(game);
        }

        public IHttpActionResult Put(GameEdit game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!service.UpdateGame(game))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {

            if (!service.DeleteGame(id))
                return InternalServerError();

            return Ok();
        }
    }
}
