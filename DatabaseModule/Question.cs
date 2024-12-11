using System;
using System.Collections.Generic;

namespace DatabaseModule;

public partial class Question
{
    public int QuestionId { get; set; }

    public int ThemeId { get; set; }

    public int UserId { get; set; }

    public string Text { get; set; } = null!;

    public virtual ICollection<Reply> Replies { get; set; } = new List<Reply>();

    public virtual Theme Theme { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public override string ToString()
    {
        return $"{Text.TrimEnd()}";
    }
}
