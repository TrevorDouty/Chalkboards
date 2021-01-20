using System.Collections.Generic;
using System.Threading.Tasks;
using chalkboards.Models;
using chalkboards.Services;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace chalkboards.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class BoardsController : ControllerBase
  {
    private readonly BoardsService _bs;


    public BoardsController(BoardsService bs)
    {
      _bs = bs;
    }

    [HttpPost]
    [Authorize]

    public async Task<ActionResult<Board>> Create([FromBody] Board board)
    {
      try
      {
        Profile userinfo = await HttpContext.GetUserInfoAsync<Profile>();
        board.CreatorId = userinfo.Id;
        Board newboard = _bs.Create(board);
        newboard.Creator = userinfo;
        return Ok(newboard);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet]

    public ActionResult<IEnumerable<Board>> Get()
    {
      try
      {
        return Ok(_bs.Get());
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]

    public ActionResult<Board> GetOne(int id)
    {
      try
      {
        return Ok(_bs.GetOne(id));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }


  }




}