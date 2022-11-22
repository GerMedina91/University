using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace UniversityApi.Models.DataModels
{
    public enum LevelCourse
    {
        basic,
        intermediate,
        advanced
    }
    public class Course
    {
        [Required, MaxLength(280)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        public string LargeDescription { get; set; } = string.Empty;
        public string TargetAudience { get; set; } = string.Empty;
        public string Objectives { get; set; } = string.Empty;
        public string Requirements { get; set; } = string.Empty;
        public LevelCourse Level { get; set; }

    }
}
