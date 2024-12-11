using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseModule;

public partial class OslearningPlatformContext : DbContext
{
    public OslearningPlatformContext()
    {
    }

    public OslearningPlatformContext(DbContextOptions<OslearningPlatformContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AttendanceAndPerformance> AttendanceAndPerformances { get; set; }

    public virtual DbSet<CourseProgram> CoursePrograms { get; set; }

    public virtual DbSet<Moderator> Moderators { get; set; }

    public virtual DbSet<NeedAnswer> NeedAnswers { get; set; }

    public virtual DbSet<ProblematicUser> ProblematicUsers { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Reply> Replies { get; set; }

    public virtual DbSet<Theme> Themes { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        #warning Connection string is in code - not good
        string connectionString = "Server=(local)\\sqlexpress;" +
            "Database=OSLearningPlatform;" +
            $"Integrated Security={integratedSecurity};" +
            "TrustServerCertificate=true;";

        if (!integratedSecurity)
        {
            connectionString += $"Authentication=Sql Password;User={user};Password={password};";
        }

        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AttendanceAndPerformance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AttendanceAndPerformance", "Service");

            entity.HasIndex(e => e.UserId, "UQ__Attendan__1788CC4D53DB605D").IsUnique();

            entity.Property(e => e.LastOnline).HasColumnType("datetime");

            entity.HasOne(d => d.LastTheme).WithMany()
                .HasForeignKey(d => d.LastThemeId)
                .HasConstraintName("FK_Performance_ThemeRef");

            entity.HasOne(d => d.User).WithOne()
                .HasForeignKey<AttendanceAndPerformance>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Performance_UserRef");
        });

        modelBuilder.Entity<CourseProgram>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CourseProgram", "Wiki");

            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Moderator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Moderator", "Service");

            entity.HasIndex(e => e.ModeratorId, "UQ__Moderato__737FFEA0BAE5DB80").IsUnique();

            entity.HasOne(d => d.ModeratorNavigation).WithOne()
                .HasForeignKey<Moderator>(d => d.ModeratorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Moderator_UserRef");
        });

        modelBuilder.Entity<NeedAnswer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NeedAnswer", "Wiki");

            entity.Property(e => e.QuestionText)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ProblematicUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ProblematicUsers", "Service");

            entity.Property(e => e.LastOnline).HasColumnType("datetime");
            entity.Property(e => e.Login)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__Question__0DC06FAC5B151A8B");

            entity.ToTable("Question", "Wiki");

            entity.Property(e => e.Text)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Theme).WithMany(p => p.Questions)
                .HasForeignKey(d => d.ThemeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Question_ThemeRef");

            entity.HasOne(d => d.User).WithMany(p => p.Questions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Question_UserRef");
        });

        modelBuilder.Entity<Reply>(entity =>
        {
            entity.HasKey(e => e.ReplyId).HasName("PK__Reply__C25E46093F1E1C6A");

            entity.ToTable("Reply", "Wiki");

            entity.Property(e => e.Text)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Question).WithMany(p => p.Replies)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reply_QuestionRef");

            entity.HasOne(d => d.User).WithMany(p => p.Replies)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reply_UserRef");
        });

        modelBuilder.Entity<Theme>(entity =>
        {
            entity.HasKey(e => e.ThemeId).HasName("PK__Theme__FBB3E4D9B68616AE");

            entity.ToTable("Theme", "Wiki");

            entity.Property(e => e.Description)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RecommendedDuration).HasDefaultValue(2);
            entity.Property(e => e.ThemeFileUrl)
                .HasMaxLength(256)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Type)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Unit).WithMany(p => p.Themes)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Theme_UnitRef");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.UnitId).HasName("PK__Unit__44F5ECB591185DCE");

            entity.ToTable("Unit", "Wiki");

            entity.Property(e => e.Description)
                .HasMaxLength(256)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CC4C2912C284");

            entity.ToTable("User", "Service");

            entity.HasIndex(e => e.Login, "UQ__User__5E55825B7CAF9C16").IsUnique();

            entity.Property(e => e.EncryptedPassword)
                .HasMaxLength(64)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Login)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
