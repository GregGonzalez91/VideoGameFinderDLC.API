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
    public class UserRatingController : ApiController
    {

        private UserRatingService CreateUserRatingService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var userRatingService = new UserRatingService(userId);
            return userRatingService;
        }

        public IHttpActionResult Post(UserRatingCreate userRating)
        {

            var service = CreateUserRatingService();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!service.CreateUserRating(userRating))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get()
        {
            var service = CreateUserRatingService();

            var userRating = service.GetUserRatings();
            return Ok(userRating);
        }

        public IHttpActionResult GetUserRatingById(int id)
        {
            var service = CreateUserRatingService();

            var userRating = service.GetUserRatingbyId(id);
            return Ok(userRating);
        }

        public IHttpActionResult Put(UserRatingEdit userRating)
        {
            var service = CreateUserRatingService();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!service.UpdateUserRating(userRating))
            {
                return InternalServerError();
            }

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateUserRatingService();

            if (!service.DeleteUserRating(id))
            {
                return InternalServerError();
            }

            return Ok();
        }
    }
       
}
