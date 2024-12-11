using System;
using System.Collections.Generic;

namespace DatabaseModule;

public partial class Moderator
{
    public int ModeratorId { get; set; }

    public virtual User ModeratorNavigation { get; set; } = null!;
}
