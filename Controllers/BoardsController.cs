using System.Threading.Tasks;
using chalkboards.Models;
using chalkboards.Services;
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

    public Task<ActionResult<Board>> Create([FromBody] Board board)
    {
      try
      {
        Profile userinfo = await HttpContext.GetUserInfoAsync<Profile>();
        board.CreatorId = userinfo.Id;
        Board newboard = _ks.Create(board);
        newboard.Creator = userinfo;
        return Ok(newboard);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }



  }




}