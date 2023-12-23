

using GameStore.Client.Models;

namespace GameStore.Client.Data;

public class GameClient
{
    private static readonly List<Game> games = new()
    {
            new Game(){
            ID = 1,
            Name ="The legend Of Zelda Twilight Princess",
            Genre = "Action Adventure",
            Price = 99.99M,
            ReleaseDate = new DateTime(2006,02,19)
            },
            new Game(){
            ID = 2,
            Name ="The legend Of Zelda Skywar Sword",
            Genre = "Action Adventure",
            Price = 99.99M,
            ReleaseDate = new DateTime(2012,02,19)
            },
            new Game(){
            ID = 3,
            Name ="The legend Of Zelda Tears of The Kingdom",
            Genre = "Action Adventure",
            Price = 99.99M,
            ReleaseDate = new DateTime(2023,02,19)
            },
    };

    public static Game[] getGames()
    {
        return games.ToArray();
    }

}