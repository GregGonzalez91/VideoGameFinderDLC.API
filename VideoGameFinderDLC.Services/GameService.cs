using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameFinderDLC.Data;
using VideoGameFinderDLC.Models;

namespace VideoGameFinderDLC.Services
{
    public class GameService
    {
       public bool CreateGame(GameCreate model)
        {
            var entity =
                new Game()
                {
                    GameTitle = model.GameTitle,
                    ReleaseDate = model.ReleaseDate,
                    PlayerCount = model.PlayerCount,
                    ESRBRating = model.ESRBRating,
                    GamePrice = model.GamePrice,
                    GameGenreId = model.GameGenreId,
                    GameSystemId = model.GameSystemId
                };



            using (var ctx = new ApplicationDbContext())
            {
                ctx.Games.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GameListItem> GetGame()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Games
                        //.Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new GameListItem
                                {
                                    GameId = e.GameId,
                                    GameTitle = e.GameTitle,
                                    GameSystemName = e.GameSystem.GameSystemName,
                                    GenreType = e.GameGenre.GenreType,
                                    ReleaseDate = e.ReleaseDate,
                                    PlayerCount = e.PlayerCount 
                                }
                        );

                return query.ToArray();
            }
        }

        public GameDetail GetGameById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Games
                        .Single(e => e.GameId == id);
                return
                    new GameDetail
                    {
                        GameId = entity.GameId,
                        GameTitle = entity.GameTitle,
                        GameSystemName = entity.GameSystem.GameSystemName,
                        GenreType = entity.GameGenre.GenreType,
                        ReleaseDate = entity.ReleaseDate,
                        PlayerCount = entity.PlayerCount

                    };
            }
        }

        public bool UpdateGame(GameEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Games
                        .Single(e => e.GameId == model.GameId);

                entity.GameTitle = model.GameTitle;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteGame(int gameId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Games
                        .Single(e => e.GameId == gameId);

                ctx.Games.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
