using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("students")]
public class Student : BaseModel
{
    [PrimaryKey("id")]
    public Guid Id { get; set; }
    
    [Column("student_id")]
    public int StudentId { get; set; }

    [Column("auth_user_id")]
    public Guid? AuthUserId { get; set; }

    [Column("full_name")]
    public string FullName { get; set; } = string.Empty;

    [Column("email")]
    public string Email { get; set; } = string.Empty;

    [Column("class_id")]
    public Guid ClassId { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}
