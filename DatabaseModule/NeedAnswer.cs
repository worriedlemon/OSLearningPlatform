using System;
using System.Collections.Generic;

namespace DatabaseModule;

public partial class NeedAnswer
{
    public int QuestionId { get; set; }

    public int ThemeId { get; set; }

    public string QuestionText { get; set; } = null!;
}
