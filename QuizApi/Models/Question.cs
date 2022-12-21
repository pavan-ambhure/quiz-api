using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApi.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        [Column(TypeName="nvarchar(50)")]
        public string QuestionInWord { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? ImageName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Option1 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Option2 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Option3 { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Option4 { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public int Answer { get; set; }

    }
}
