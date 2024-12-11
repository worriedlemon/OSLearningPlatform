using System;
using System.Collections.Generic;

namespace DatabaseModule;

public partial class ProblematicUser
{
    public int UserId { get; set; }

    public string Login { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime? LastOnline { get; set; }
}
