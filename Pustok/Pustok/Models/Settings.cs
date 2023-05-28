using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Settings
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(35)]    
        public string Key { get; set; }
        public string Value { get; set; }
       
    }
}
