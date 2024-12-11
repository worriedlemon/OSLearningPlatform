using System;
using System.Collections.Generic;

namespace DatabaseModule;

public partial class Unit
{
    public int UnitId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Theme> Themes { get; set; } = new List<Theme>();

    public override string ToString() => Name.TrimEnd();
}
