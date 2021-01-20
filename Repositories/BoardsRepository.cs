using System.Collections.Generic;
using System.Data;
using chalkboards.Models;
using Dapper;

namespace chalkboards.Repositories
{
  public class BoardsRepository
  {
    private readonly IDbConnection _db;
    private readonly string populateCreator = "SELECT board.*, profile.* FROM boards board INNER JOIN profiles profile ON board.creatorId = profile.id";

    public BoardsRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Board> Get()
    {
      string sql = populateCreator;
      return _db.Query<Board, Profile, Board>(sql, (board, profile) => { board.Creator = profile; return board; }, splitOn: "id");
    }

    public Board GetOne(int id)
    {
      string sql = "SELECT * FROM boards WHERE id = @id";
      return _db.QueryFirstOrDefault<Board>(sql, new { id });
    }


    public int Create(Board Board)
    {
      string sql = @"INSERT INTO boards
      (title, description, img, id, creatorId, quantity, price)
      VALUES
      (@Title, @Description, @Img, @Id, @CreatorId, @Quantity, @Price);
      SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, Board);
    }

    public bool Delete(int id)
    {
      string sql = "DELETE FROM Boards WHERE id = @id LIMIT 1;";
      int affectedRows = _db.Execute(sql, new { id });
      return affectedRows == 1;
    }

    internal IEnumerable<Board> GetBoardsByProfile(string profileId)
    {
      string sql = @"SELECT board.*, p.*
   FROM boards board 
   JOIN profiles p ON board.creatorId = p.id
   WHERE board.creatorId = @profileId;";
      return _db.Query<Board, Profile, Board>(sql, (board, profile) => { board.Creator = profile; return board; }, new { profileId }, splitOn: "id");
    }
  }
}