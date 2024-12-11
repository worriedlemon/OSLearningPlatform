using System;
using System.Collections.Generic;

namespace DatabaseModule;

public partial class Theme
{
    public int ThemeId { get; set; }

    public int UnitId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Type { get; set; } = null!;

    public int RecommendedDuration { get; set; }

    public string? ThemeFileUrl { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual Unit Unit { get; set; } = null!;
}
