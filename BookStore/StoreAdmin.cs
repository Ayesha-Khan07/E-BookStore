using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _2ndBookStore
{
    public class StoreAdmin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; } = null!;
        public string AdmEmail { get; set; } = null!;

        public string AdmPassword { get; set; } = null!;
    }
}
