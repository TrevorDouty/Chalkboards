using System;
using System.Collections.Generic;
using chalkboards.Models;
using chalkboards.Repositories;

namespace chalkboards.Services
{
  public class BoardsService
  {
    private readonly BoardsRepository _repo;
    public IEnumerable<Board> Get()
    {
      return _repo.Get();
    }

    internal Board GetOne(int id)
    {
      Board foundBoard = _repo.GetOne(id);
      if (foundBoard == null)
      {
        throw new Exception("This Board doesn't exist");
      }
      return foundBoard;

    }


    public string Delete(int id, string userId)
    {
      Board original = _repo.GetOne(id);
      if (original == null)
      {
        throw new Exception("Incorrect Id");
      }
      else if (original.CreatorId != userId)
      {
        throw new Exception("Not allowed");
      }
      else if (_repo.Delete(id))
      {
        return "Deleted";
      }
      return "Could not delete";
    }

    internal Board Create(Board board)
    {
      board.Id = _repo.Create(board);
      return board;
    }

    internal IEnumerable<Board> GetBoardsByProfile(string profileId, string userId)
    {
      return _repo.GetBoardsByProfile(profileId);
    }
  }
}