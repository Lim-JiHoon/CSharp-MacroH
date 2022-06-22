using HoonsLib.SQLiteEx;
using MacroH.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MacroH.Repositorys
{
  public class MacroRepository
  {
    public static async Task Create(string filePath)
    {
      FileInfo fi = new FileInfo(filePath);

      using (var sqlite = new SQLiteEx(filePath))
      {
        string sql = @$"
DROP TABLE IF EXISTS macro;
CREATE TABLE IF NOT EXISTS macro(
id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT ,
kind VARCHAR(10) NOT NULL,
action VARCHAR(20) NOT NULL,
text TEXT NOT NULL,
mousepoint VARCHAR(20) NOT NULL,
delay DOUBLE NOT NULL
);";
        await sqlite.Execute(sql);
      }
    }

    public static async Task Save(string filePath, Macro macro)
    {
      using (var sqlite = new SQLiteEx(filePath))
      {
        string sql = @$"
INSERT INTO macro(
kind, action, text, mousepoint, delay
) VALUES (
'{macro.Kind}', '{macro.Action}', '{macro.Text}', '{macro.MousePoint}', {macro.Delay}
);";
        await sqlite.Execute(sql);
      }
    }

    public static async Task<List<Macro>> GetMacros(string filePath)
    {
      var macros = new List<Macro>();
      using (var sqlite = new SQLiteEx(filePath))
      {
        string sql = @$"
SELECT * FROM macro";
        var dr = await sqlite.Reader(sql);
        if (dr.HasRows)
        {
          while (dr.Read())
          {
            macros.Add(new Macro(dr));
          }
        }
        dr.Close();
      }

      return macros;
    }
  }
}
