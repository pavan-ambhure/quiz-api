using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApi.Models
{
    public class Participant
    {
        public int ParticipantId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public int Score { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public int TimeTaken { get; set; }
    }


    public class ParticipantResult
    {
        public int ParticipantId { get; set; }

        public int Score { get; set; }

        public int TimeTaken { get; set; }
    }
}
