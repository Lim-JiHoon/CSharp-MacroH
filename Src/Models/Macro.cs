using System.Drawing;

namespace MacroH.Models
{
  public class Macro
  {
    public long Id { get; set; } = 0;
    public string Kind { get; set; } = "";
    public string Action { get; set; } = "";
    public string Text { get; set; } = "";
    public string MousePoint { get; set; } = "";
    public double Delay { get; set; } = 0;

    public Point Point
    {
      get
      {
        string[] arr = MousePoint.Split(",");
        if (arr.Length == 2)
        {
          return new Point(int.Parse(arr[0]), int.Parse(arr[1]));
        }
        else
        {
          return Point.Empty;
        }
      }
    }

    public Macro() { }
    public Macro(System.Data.Common.DbDataReader dr)
    {
      Id = (long)dr["id"];
      Kind = (string)(dr["kind"]);
      Action = (string)(dr["action"]);
      Text = (string)(dr["text"]);
      MousePoint = (string)(dr["mousepoint"]);
      Delay = (double)dr["delay"];
    }
  }
}
