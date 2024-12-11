using System;
using System.Collections.Generic;

namespace DatabaseModule;

public partial class CourseProgram
{
    public int UnitId { get; set; }

    public string Name { get; set; } = null!;

    public int? ThemesCount { get; set; }

    public int? OverallDuration { get; set; }
}
