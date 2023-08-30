namespace WebApiBootcampPrac.Models
{
    public class Score
    {
        public int Id { get; set; }

        public int Points { get; set; }

        public int StudentId { get; set; }
        public virtual Student? Student { get; set; } = null;

        public int AssessmentId { get; set; }
        public virtual Assessment? Assessment { get; set; } = null;
    }
}
