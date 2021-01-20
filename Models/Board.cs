using chalkboards.Models;

namespace chalkboards.Models
{
  public class Board
  {
    public string Img { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public int Id { get; set; }

    public string CreatorId { get; set; }
    public Profile Creator { get; set; }
  }
}