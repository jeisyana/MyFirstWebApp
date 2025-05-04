using System.ComponentModel.DataAnnotations;

namespace MyFirstWebApp.Models
{
    public class Station
    {
        [Key]
        public int Id { get; set; }  // 主キー

        [Required]
        [StringLength(50)]
        public required string Name { get; set; } // 駅名

        [Required]
        [StringLength(50)]
        public required  string Kana { get; set; } // よみかた

        [Required]
        [StringLength(50)]
        public required string LineName { get; set; } // 路線名
    }
}
