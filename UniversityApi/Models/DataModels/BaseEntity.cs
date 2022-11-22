using System.ComponentModel.DataAnnotations;

namespace UniversityApi.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreateBy { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime? UpdateDate { get; set; }
        public string DeleteBy { get; set; } = string.Empty;
        public DateTime? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
