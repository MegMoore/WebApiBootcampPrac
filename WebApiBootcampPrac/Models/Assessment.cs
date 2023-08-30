using System.ComponentModel.DataAnnotations;

namespace WebApiBootcampPrac.Models
{
    public class Assessment
    {

        public int Id { get; set; }
        [StringLength(30)]
        public string? Git { get; set; }
        [StringLength(30)]
        public string? SQL { get; set; }
        [StringLength(30)]
        public string? CSharp { get; set; }
        [StringLength(30)]
        public string? HtmlCssJs { get; set; }
        [StringLength(30)]
        public string? Angular { get; set; }
    }
}
