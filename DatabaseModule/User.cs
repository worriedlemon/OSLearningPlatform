using System;
using System.Collections.Generic;

namespace DatabaseModule;

public partial class User
{
    public int UserId { get; set; }

    public string Login { get; set; } = null!;

    public string EncryptedPassword { get; set; } = null!;

    public string? Name { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<Reply> Replies { get; set; } = new List<Reply>();
}
