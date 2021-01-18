using System;
using System.Collections.Generic;
using chalkboards.Models;
using chalkboards.Repositories;
using Microsoft.Extensions.Logging;

namespace chalkboards.Services
{
  public class ProfilesService
  {
    private readonly ProfilesRepository _repo;

    public ProfilesService(ProfilesRepository repo)
    {
      _repo = repo;
    }


    public Profile GetorCreate(Profile userInfo)
    {
      Profile foundprofile = _repo.Get(userInfo.Email);
      if (foundprofile == null)
      {
        return _repo.Create(userInfo);
      }
      return foundprofile;
    }

    internal Profile GetOne(string id)
    {
      Profile foundprofile = _repo.GetOne(id);
      if (foundprofile == null)
      {
        throw new Exception("Profile doesn't exist");
      }
      return foundprofile;
    }
  }
}