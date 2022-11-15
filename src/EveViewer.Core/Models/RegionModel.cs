using System;

namespace EveViewer.Core.Models
{
  public class RegionModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<int> ConstellationIds { get; set; }

    public RegionModel()
    {
      this.Id = -1;
      this.Name = string.Empty;
      this.ConstellationIds = new List<int>();
    }
  }
}