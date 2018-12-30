using System.ComponentModel.DataAnnotations;

namespace basicbp.Models
{
    public class Items
    {
        public int Id {get; set; }
        [Required]
        [Display(Name="Full Name")]
        public string Name {get; set;}
    }
}