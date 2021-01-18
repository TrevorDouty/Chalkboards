using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using keepr.Models;

namespace keepr.Repositories
{
  public class ProfilesRepository
  {
    private readonly IDbConnection _db;

    public ProfilesRepository(IDbConnection db)
    {
      _db = db;
    }

    public Profile Get(string email)
    {
      string sql = @"
      SELECT * FROM profiles WHERE email = @email
      ";
      return _db.QueryFirstOrDefault<Profile>(sql, new { email });
    }



    public Profile Create(Profile userinfo)
    {
      string sql = @"
      INSERT INTO profiles
      (name, email, picture, id)
      VALUES
      (@Name, @Email, @Picture, @Id)";
      _db.Execute(sql, userinfo);
      return userinfo;
    }

    internal Profile GetOne(string id)
    {
      string sql = @"
      SELECT * FROM profiles WHERE id = @id";
      return _db.QueryFirstOrDefault<Profile>(sql, new { id });

    }
  }
}