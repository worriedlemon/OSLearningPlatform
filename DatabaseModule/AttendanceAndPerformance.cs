using System;
using System.Collections.Generic;

namespace DatabaseModule;

public partial class AttendanceAndPerformance
{
    public int UserId { get; set; }

    public DateTime? LastOnline { get; set; }

    public int? LastThemeId { get; set; }

    public virtual Theme? LastTheme { get; set; }

    public virtual User User { get; set; } = null!;
}
