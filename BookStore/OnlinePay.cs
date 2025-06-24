using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _2ndBookStore
{
    public class OnlinePay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; } = null!;
        public string UserName { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string ContactNum { get; set; } = null!;

        public string CreditCardNum { get; set; } = null!;
    }
}
