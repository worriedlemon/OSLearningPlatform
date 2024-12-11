using System;
using System.Collections.Generic;

namespace DatabaseModule;

public partial class Reply
{
    public int ReplyId { get; set; }

    public int QuestionId { get; set; }

    public int UserId { get; set; }

    public string Text { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
