using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameFinderDLC.Data;
using VideoGameFinderDLC.Models;

namespace VideoGameFinderDLC.Services
{
    public class UserRatingService
    {
        private readonly Guid _userId;

        public UserRatingService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateUserRating(UserRatingCreate model)
        {
            var entity =
                new UserRating()
                {
                    OwnerId = _userId,
                    UserGameRating = model.UserGameRating,
                    IsRecommended = model.IsRecommended
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.UserRatings.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<UserRatingListItem> GetUserRatings()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =//querying db
                    ctx
                    .UserRatings
                    .Select(//selecting multiple records
                        e =>
                        new UserRatingListItem
                        {
                            UserGameRating = e.UserGameRating,
                            IsRecommended = e.IsRecommended,
                            GameId = e.GameId
                        });
                return query.ToArray();//ToArray taking data from db and putting it into 
                //Array
            }
        }

        public UserRatingDetail GetUserRatingbyId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .UserRatings
                    .Single(e => e.UserRatingId == id);//id in postman matches with UserId

                return new UserRatingDetail
                {
                    UserGameRating = entity.UserGameRating,
                    IsRecommended = entity.IsRecommended,
                    GameId = entity.GameId
                };
            }
        }

        public bool UpdateUserRating(UserRatingEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .UserRatings
                    .Single(e => e.UserRatingId == model.UserRatingId);
                entity.UserGameRating = model.UserGameRating;
                entity.IsRecommended = model.IsRecommended;
                entity.GameId = model.GameId;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteUserRating(int userId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .UserRatings
                    .Single(e => e.UserRatingId == userId);

                ctx.UserRatings.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
